using Intent.Engine;
using Intent.Modules.AspNetCore.Templates.Startup;
using Intent.Modules.Common;
using Intent.Modules.Common.VisualStudio;
using Intent.Modules.IdentityServer4.SecureTokenServer.Templates.IdentityServerConfiguration;
using Intent.RoslynWeaver.Attributes;
using System.Collections.Generic;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateDecorator", Version = "1.0")]

namespace Intent.Modules.IdentityServer4.Identity.EFCore.Decorators
{
    [IntentManaged(Mode.Merge)]
    public class AspNetIdentityUserDecorator : IdentityConfigurationDecorator, IDeclareUsings, IHasNugetDependencies
    {
        [IntentManaged(Mode.Fully)]
        public const string DecoratorId = "Intent.IdentityServer4.Identity.EFCore.AspNetIdentityUserDecorator";

        private readonly IdentityServerConfigurationTemplate _template;
        private readonly IApplication _application;

        [IntentManaged(Mode.Merge)]
        public AspNetIdentityUserDecorator(IdentityServerConfigurationTemplate template, IApplication application)
        {
            _template = template;
            _application = application;
            Priority = -7;
        }

        public override string ConfigureServices()
        {
            return "idServerBuilder.AddAspNetIdentity<IdentityUser>();";
        }

        public IEnumerable<string> DeclareUsings()
        {
            return new[]
            {
                "IdentityServer4.AspNetIdentity",
                "Microsoft.AspNetCore.Identity"
            };
        }

        public IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.IdentityServer4AspNetIdentity
            };
        }
    }
}