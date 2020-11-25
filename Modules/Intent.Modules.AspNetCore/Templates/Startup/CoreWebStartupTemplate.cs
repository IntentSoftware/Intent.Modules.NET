﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNetCore.Templates.Startup
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CoreWebStartupTemplate : CSharpTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            
            #line 14 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"




            
            #line default
            #line hidden
            this.Write(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
");
            
            #line 28 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  if (!IsNetCore2App()) { 
            
            #line default
            #line hidden
            this.Write("using Microsoft.Extensions.Hosting;\r\n");
            
            #line 30 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 34 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge)]\r\n    public class ");
            
            #line 37 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public ");
            
            #line 39 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // [IntentManaged(Mode.Ignore)] // Uncomment this line to take over management of configuring services
        public void ConfigureServices(IServiceCollection services)
        {
");
            
            #line 49 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  if (IsNetCore2App()) { 
            
            #line default
            #line hidden
            this.Write("            services.AddMvc();\r\n");
            
            #line 51 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  } else { 
            
            #line default
            #line hidden
            this.Write("            services.AddControllers();\r\n");
            
            #line 53 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("            IntentConfiguredServices(services);\r\n");
            
            #line 55 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ServiceConfigurations()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n\r\n        // This method gets called by the runtime. Use this method" +
                    " to configure the HTTP request pipeline.\r\n        public void Configure(IApplica" +
                    "tionBuilder app, ");
            
            #line 59 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((IsNetCore2App() ? "IHostingEnvironment" : "IWebHostEnvironment")));
            
            #line default
            #line hidden
            this.Write(" env)\r\n        {\r\n            if (env.IsDevelopment())\r\n            {\r\n          " +
                    "      app.UseDeveloperExceptionPage();\r\n            }\r\n");
            
            #line 65 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  if (IsNetCore2App()) { 
            
            #line default
            #line hidden
            this.Write("            else\r\n            {\r\n                // The default HSTS value is 30 " +
                    "days. You may want to change this for production scenarios, see https://aka.ms/a" +
                    "spnetcore-hsts.\r\n                app.UseHsts();\r\n            }\r\n");
            
            #line 71 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 73 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  if (IsNetCore2App()) { 
            
            #line default
            #line hidden
            this.Write("            app.UseHttpsRedirection();\r\n            \r\n            app.UseMvc();\r\n" +
                    "");
            
            #line 77 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  } else { 
            
            #line default
            #line hidden
            this.Write("            app.UseHttpsRedirection();\r\n\r\n            app.UseRouting();\r\n\r\n      " +
                    "      app.UseAuthorization();\r\n\r\n            app.UseEndpoints(endpoints =>\r\n    " +
                    "        {\r\n                endpoints.MapControllers();\r\n            });\r\n");
            
            #line 88 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 89 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configurations()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n\r\n        public void IntentConfiguredServices(IServiceCollection se" +
                    "rvices) \r\n        {\r\n");
            
            #line 94 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Registrations()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n\r\n");
            
            #line 97 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.AspNetCore\Templates\Startup\CoreWebStartupTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Methods()));
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}