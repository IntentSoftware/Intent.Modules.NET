﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.VisualStudio.Projects.Templates.CoreWeb.CsProject
{
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.VisualStudio;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CoreWebCSProjectTemplate : VisualStudioProjectTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk.Web\">\r\n\r\n  <PropertyGroup>\r\n    <TargetFramework>" +
                    "");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Project.TargetFramework()));
            
            #line default
            #line hidden
            this.Write("</TargetFramework>\r\n  </PropertyGroup>\r\n\r\n");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
  if (Project.TargetFramework().StartsWith("netcoreapp2")) { 
            
            #line default
            #line hidden
            this.Write(@"  <ItemGroup>
    <PackageReference Include=""Microsoft.AspNetCore.All"" Version=""2.1.1"" />
    <PackageReference Include=""Microsoft.VisualStudio.Web.CodeGeneration.Design"" Version=""2.1.1"" />
  </ItemGroup>

  <ItemGroup>
    <DotNetCliToolReference Include=""Microsoft.VisualStudio.Web.CodeGeneration.Tools"" Version=""2.0.4"" />
  </ItemGroup>

");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("</Project>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}