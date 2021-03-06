using Intent.Engine;
using Intent.Modules.AspNetCore.Templates.Startup;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.EntityFrameworkCore.Templates.DbContext;
using Intent.Modules.IdentityServer4.SecureTokenServer.Templates.IdentityServerConfiguration;
using Intent.RoslynWeaver.Attributes;
using System.Collections.Generic;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateDecorator", Version = "1.0")]

namespace Intent.Modules.IdentityServer4.Identity.EFCore.Decorators
{
    [IntentManaged(Mode.Merge)]
    public class IdentityUserDecorator : IdentityConfigurationDecorator, IDeclareUsings
    {
        [IntentManaged(Mode.Fully)]
        public const string DecoratorId = "Intent.IdentityServer4.Identity.EFCore.IdentityUserDecorator";

        private readonly IdentityServerConfigurationTemplate _template;
        private readonly IApplication _application;

        [IntentManaged(Mode.Merge)]
        public IdentityUserDecorator(IdentityServerConfigurationTemplate template, IApplication application)
        {
            _template = template;
            _application = application;
            Priority = -50;
        }

        public override string ConfigureServices()
        {
            var dbContextTemplate = _application.FindTemplateInstance<IClassProvider>(DbContextTemplate.TemplateId);

            return $@"
services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<{dbContextTemplate.FullTypeName()}>()
    ;";
        }

        public IEnumerable<string> DeclareUsings()
        {
            return new[]
            {
                "Microsoft.AspNetCore.Identity",
                "Microsoft.AspNetCore.Identity.EntityFrameworkCore"
            };
        }
    }
}