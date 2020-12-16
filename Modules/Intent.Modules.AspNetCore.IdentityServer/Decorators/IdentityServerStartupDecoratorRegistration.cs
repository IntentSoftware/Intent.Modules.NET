using System.ComponentModel;
using Intent.Engine;
using Intent.Modules.AspNetCore.Templates.Startup;
using Intent.Modules.Common.Registrations;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("ModuleBuilder.Templates.TemplateDecoratorRegistration", Version = "1.0")]

namespace Intent.Modules.AspNetCore.IdentityServer.Decorators
{
    [Description(IdentityServerStartupDecorator.DecoratorId)]
    public class IdentityServerStartupDecoratorRegistration : DecoratorRegistration<StartupTemplate, StartupDecorator>
    {
        public override StartupDecorator CreateDecoratorInstance(StartupTemplate template, IApplication application)
        {
            return new IdentityServerStartupDecorator(template);
        }

        public override string DecoratorId => IdentityServerStartupDecorator.DecoratorId;
    }
}