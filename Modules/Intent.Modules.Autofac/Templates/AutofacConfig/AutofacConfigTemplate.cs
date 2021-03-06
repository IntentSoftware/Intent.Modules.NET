﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Autofac.Templates.AutofacConfig
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Autofac\Templates\AutofacConfig\AutofacConfigTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AutofacConfigTemplate : CSharpTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing System;\r\nusing System.Linq;\r\nusing System.Collections.Generic;\r\nusing Au" +
                    "tofac;\r\nusing Autofac.Extensions.DependencyInjection;\r\n");
            
            #line 18 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Autofac\Templates\AutofacConfig\AutofacConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Autofac\Templates\AutofacConfig\AutofacConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge)]\r\n    public class ");
            
            #line 25 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Autofac\Templates\AutofacConfig\AutofacConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"
    {
        #region Autofac Container
        private static readonly Lazy<IContainer> Container = new Lazy<IContainer>(() =>
        {
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);
            return builder.Build();
        });

        /// <summary>
        /// Gets the configured Autofac container.
        /// </summary>
        public static IContainer GetConfiguredContainer()
        {
            return Container.Value;
        }
        #endregion

        private static void ConfigureContainer(ContainerBuilder builder)
        {
            ConfigureGeneratedRegistrations(builder);
            ConfigureCustomRegistrations(builder);
        }

        private static void ConfigureGeneratedRegistrations(ContainerBuilder builder)
        {
            builder.RegisterType<AutofacServiceProvider>().As<IServiceProvider>();
            ");
            
            #line 53 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Autofac\Templates\AutofacConfig\AutofacConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Registrations()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n\r\n        [IntentManaged(Mode.Ignore)]\r\n        private static void " +
                    "ConfigureCustomRegistrations(ContainerBuilder builder)\r\n        {\r\n            /" +
                    "/Add Custom Registrations\r\n        }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
