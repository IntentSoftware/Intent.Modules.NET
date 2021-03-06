using System.Collections.Generic;
using Intent.Engine;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;


[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.Application.AutoMapper.Templates.MapFromInterface
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class MapFromInterfaceTemplate : CSharpTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.Application.AutoMapper.MapFromInterface";

        public MapFromInterfaceTemplate(IOutputTarget outputTarget, object model) : base(TemplateId, outputTarget, model)
        {
            AddNugetDependency(NugetPackages.AutoMapper);
        }

        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"IMapFrom",
                @namespace: $"{OutputTarget.GetNamespace()}");
        }

    }
}