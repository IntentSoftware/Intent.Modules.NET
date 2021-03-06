﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Common.Plugins;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.VisualStudio;
using Intent.Modules.Constants;
using Intent.Engine;
using Intent.Eventing;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp;
using Intent.Modules.Common.CSharp.Configuration;
using Intent.Modules.Common.CSharp.DependencyInjection;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.EntityFramework.Templates.EFMapping;
using Intent.Templates;

namespace Intent.Modules.EntityFramework.Templates.DbContext
{
    partial class DbContextTemplate : CSharpTemplateBase<IEnumerable<ClassModel>>, ITemplate, IHasNugetDependencies, ITemplateBeforeExecutionHook, IHasDecorators<DbContextDecoratorBase>
    {
        public const string Identifier = "Intent.EntityFramework.DbContext";

        private readonly IApplicationEventDispatcher _eventDispatcher;
        private IList<DbContextDecoratorBase> _decorators = new List<DbContextDecoratorBase>();

        public DbContextTemplate(IEnumerable<ClassModel> models, IProject project, IApplicationEventDispatcher eventDispatcher)
            : base(Identifier, project, models)
        {
            _eventDispatcher = eventDispatcher;
        }

        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"{Project.Application.Name}DbContext".ToCSharpIdentifier(),
                @namespace: $"{OutputTarget.GetNamespace()}");
        }
        
        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.EntityFramework,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        public override void BeforeTemplateExecution()
        {
            ExecutionContext.EventDispatcher.Publish(new ConnectionStringRegistrationRequest(
                name: $"{Project.Application.Name}DB",
                connectionString: $"Server=.;Initial Catalog={ OutputTarget.Application.Name };Integrated Security=true;MultipleActiveResultSets=True",
                providerName: "System.Data.SqlClient"));

            ExecutionContext.EventDispatcher.Publish(ContainerRegistrationRequest.ToRegister(this)
                .WithPerServiceCallLifeTime());
        }

        public void AddDecorator(DbContextDecoratorBase decorator)
        {
            _decorators.Add(decorator);
        }

        public IEnumerable<DbContextDecoratorBase> GetDecorators()
        {
            return _decorators;
        }

        public string GetMethods()
        {
            var code = string.Join(Environment.NewLine + Environment.NewLine,
                GetDecorators()
                    .SelectMany(s => s.GetMethods())
                    .Where(p => !string.IsNullOrEmpty(p)));
            if (string.IsNullOrWhiteSpace(code))
            {
                return string.Empty;
            }
            return Environment.NewLine + Environment.NewLine + code;
        }

        public string GetBaseClass()
        {
            try
            {
                return NormalizeNamespace(GetDecorators().Select(x => x.GetBaseClass()).SingleOrDefault(x => x != null) ?? "System.Data.Entity.DbContext");
            }
            catch (InvalidOperationException)
            {
                throw new Exception($"Multiple decorators attempting to modify 'base class' on {Identifier}");
            }
        }

        private string GetMappingName(ClassModel model)
        {
            return GetTypeName(EFMappingTemplate.Identifier, model);
        }
    }
}
