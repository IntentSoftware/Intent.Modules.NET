using System.ComponentModel;
using Intent.Engine;
using Intent.Modules.AspNetCore.Templates.Startup;
using Intent.Modules.Common.Registrations;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateDecoratorRegistration", Version = "1.0")]

namespace Intent.Modules.AspNetCore.Cors.Decorators
{
    [Description(CorsStartupDecorator.DecoratorId)]
    public class CorsStartupDecoratorRegistration : DecoratorRegistration<StartupTemplate, StartupDecorator>
    {
        public override StartupDecorator CreateDecoratorInstance(StartupTemplate template, IApplication application)
        {
            return new CorsStartupDecorator(template, application);
        }

        public override string DecoratorId => CorsStartupDecorator.DecoratorId;
    }
}