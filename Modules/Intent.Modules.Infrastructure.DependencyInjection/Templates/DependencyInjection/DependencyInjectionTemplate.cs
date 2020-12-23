// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Infrastructure.DependencyInjection.Templates.DependencyInjection
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class DependencyInjectionTemplate : CSharpTemplateBase<object, Intent.Modules.Infrastructure.DependencyInjection.Templates.DependencyInjection.DependencyInjectionDecorator>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using Microsoft.Extensions.Configuration;\r\nusing Microsoft.Extensions.DependencyI" +
                    "njection;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 15 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public static class ");
            
            #line 17 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public static IServiceCollection AddInfrastructure(this IService" +
                    "Collection services, IConfiguration configuration)\r\n        {\r\n");
            
            #line 21 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
  foreach(var decorator in GetDecorators()) { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 22 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decorator.ServiceRegistration()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 23 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 24 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
  foreach(var registration in _registrationRequests) { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 25 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DefineServiceRegistration(registration)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Infrastructure.DependencyInjection\Templates\DependencyInjection\DependencyInjectionTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("            return services;\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}