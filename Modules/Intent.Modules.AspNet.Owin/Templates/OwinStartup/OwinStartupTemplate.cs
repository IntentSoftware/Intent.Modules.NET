﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNet.Owin.Templates.OwinStartup
{
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class OwinStartupTemplate : CSharpTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 14 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"




            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.IO;\r\nusing System." +
                    "Linq;\r\nusing Microsoft.Owin;\r\nusing Owin; \r\n");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: OwinStartup(typeof(");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".Startup))]\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge)]\r\n    public partial class Startup\r\n    {\r\n  " +
                    "      public void Configuration(IAppBuilder app)\r\n        {");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration()));
            
            #line default
            #line hidden
            this.Write("\r\n            CustomConfiguration(app);\r\n        }\r\n\r\n        [IntentManaged(Mode" +
                    ".Ignore)]\r\n        public void CustomConfiguration(IAppBuilder app)\r\n        {\r\n" +
                    "            // Put your own custom configuration here\r\n        }");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.Owin\Templates\OwinStartup\OwinStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Methods()));
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}