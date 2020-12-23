// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.MediatR.FluentValidation.Templates.ValidationBehaviour
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.MediatR.FluentValidation\Templates\ValidationBehaviour\ValidationBehaviourTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ValidationBehaviourTemplate : CSharpTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using ValidationException = CleanArchitecture.Application.Common.Exceptions.ValidationException;

[assembly: DefaultIntentManaged(Mode.Fully)]

namespace ");
            
            #line 20 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.MediatR.FluentValidation\Templates\ValidationBehaviour\ValidationBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 22 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.MediatR.FluentValidation\Templates\ValidationBehaviour\ValidationBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>\r\n        where TRe" +
                    "quest : IRequest<TResponse>\r\n    {\r\n        private readonly IEnumerable<IValida" +
                    "tor<TRequest>> _validators;\r\n\r\n        public ");
            
            #line 27 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.MediatR.FluentValidation\Templates\ValidationBehaviour\ValidationBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);

                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();

                if (failures.Count != 0)
                    throw new ");
            
            #line 42 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.MediatR.FluentValidation\Templates\ValidationBehaviour\ValidationBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetValidationException()));
            
            #line default
            #line hidden
            this.Write("(failures);\r\n            }\r\n            return await next();\r\n        }\r\n    }\r\n}" +
                    "");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}