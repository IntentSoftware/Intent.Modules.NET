// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.Identity.Templates.AuthorizeAttribute
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.Identity\Templates\AuthorizeAttribute\AuthorizeAttributeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AuthorizeAttributeTemplate : CSharpTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 14 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.Identity\Templates\AuthorizeAttribute\AuthorizeAttributeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Specifies the class this attribute is applied to " +
                    "requires authorization.\r\n    /// </summary>\r\n    [AttributeUsage(AttributeTarget" +
                    "s.Class, AllowMultiple = true, Inherited = true)]\r\n    public class ");
            
            #line 20 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.Identity\Templates\AuthorizeAttribute\AuthorizeAttributeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : Attribute\r\n    {\r\n        /// <summary>\r\n        /// Initializes a new instanc" +
                    "e of the <see cref=\"AuthorizeAttribute\"/> class. \r\n        /// </summary>\r\n     " +
                    "   public ");
            
            #line 25 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Application.Identity\Templates\AuthorizeAttribute\AuthorizeAttributeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"() { }

        /// <summary>
        /// Gets or sets a comma delimited list of roles that are allowed to access the resource.
        /// </summary>
        public string Roles { get; set; }

        /// <summary>
        /// Gets or sets the policy name that determines access to the resource.
        /// </summary>
        public string Policy { get; set; }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}