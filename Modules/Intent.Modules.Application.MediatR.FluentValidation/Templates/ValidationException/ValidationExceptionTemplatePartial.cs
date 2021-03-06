using System.Collections.Generic;
using Intent.Engine;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;


[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.Application.MediatR.FluentValidation.Templates.ValidationException
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class ValidationExceptionTemplate : CSharpTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.Application.MediatR.FluentValidation.ValidationException";

        public ValidationExceptionTemplate(IOutputTarget outputTarget, object model) : base(TemplateId, outputTarget, model)
        {
            AddNugetDependency(NuGetPackages.FluentValidation);
        }

        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"ValidationException",
                @namespace: $"{OutputTarget.GetNamespace()}");
        }
    }
}