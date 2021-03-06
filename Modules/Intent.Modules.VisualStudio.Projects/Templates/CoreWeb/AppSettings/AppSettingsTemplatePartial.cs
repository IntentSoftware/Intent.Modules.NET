using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Intent.Modules.Common.Templates;
using Intent.Modules.Constants;
using Intent.Modules.VisualStudio.Projects.Templates.WebConfig;
using Intent.Engine;
using Intent.Eventing;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp.Configuration;
using Intent.Templates;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]
[assembly: DefaultIntentManaged(Mode.Merge)]

namespace Intent.Modules.VisualStudio.Projects.Templates.CoreWeb.AppSettings
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class AppSettingsTemplate : IntentTemplateBase<object, AppSettingsDecorator>, IHasDecorators<AppSettingsDecorator>
    {

        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.VisualStudio.Projects.CoreWeb.AppSettings";
        private readonly IList<AppSettingRegistrationRequest> _appSettings = new List<AppSettingRegistrationRequest>();
        private readonly IList<ConnectionStringRegistrationRequest> _connectionStrings = new List<ConnectionStringRegistrationRequest>();

        public AppSettingsTemplate(IProject project, IApplicationEventDispatcher eventDispatcher)
            : base(TemplateId, project, null)
        {
            eventDispatcher.Subscribe<AppSettingRegistrationRequest>(HandleAppSetting);
            eventDispatcher.Subscribe<ConnectionStringRegistrationRequest>(HandleConnectionString);
        }

        public override string RunTemplate()
        {
            var meta = GetMetadata();
            var fullFileName = Path.Combine(meta.GetFullLocationPath(), meta.FileNameWithExtension());

            var jsonObject = new AppSettingsEditor(LoadOrCreate(fullFileName));

            foreach (var appSetting in _appSettings)
            {
                jsonObject.AddPropertyIfNotExists(appSetting.Key, appSetting.Value);
            }

            foreach (var connectionString in _connectionStrings)
            {
                jsonObject.AddPropertyIfNotExists("ConnectionStrings", new object());
                var configConnectionStrings = jsonObject.GetProperty("ConnectionStrings");
                if (configConnectionStrings[connectionString.Name] == null)
                {
                    configConnectionStrings[connectionString.Name] = connectionString.ConnectionString;
                }
                jsonObject.SetProperty("ConnectionStrings", configConnectionStrings);
            }

            foreach (var decorator in GetDecorators())
            {
                decorator.UpdateSettings(jsonObject);
            }

            return JsonConvert.SerializeObject(jsonObject.Value, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }

        private dynamic LoadOrCreate(string fullFileName)
        {
            return File.Exists(fullFileName)
                ? JsonConvert.DeserializeObject(File.ReadAllText(fullFileName))
                : JsonConvert.DeserializeObject(TransformText());
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: "appsettings",
                fileExtension: "json"
            );
        }

        private void HandleAppSetting(AppSettingRegistrationRequest @event)
        {
            if (_appSettings.Any(x => x.Key == @event.Key && x.Value != @event.Value))
            {
                // Throw exception?
                return;
            }
            _appSettings.Add(@event);
        }

        private void HandleConnectionString(ConnectionStringRegistrationRequest @event)
        {
            if (_connectionStrings.Any(x => x.Name == @event.Name && x.ConnectionString != @event.ConnectionString))
            {
                throw new Exception($"Misconfiguration in [{GetType().Name}]: ConnectionString with name [{@event.Name}] already defined with different value to [{@event.ConnectionString}].");
            }
            _connectionStrings.Add(@event);
        }
    }

    public class ConnectionString
    {
    }

    public class AppSettingsEditor
    {
        private readonly dynamic _appSettings;

        public AppSettingsEditor(dynamic appSettings)
        {
            _appSettings = appSettings;
        }

        public dynamic Value => _appSettings;

        public bool PropertyExists(string key)
        {
            return _appSettings[key] != null;
        }

        public dynamic GetProperty(string key)
        {
            return PropertyExists(key) ? _appSettings[key] : default;
        }

        public T GetPropertyAs<T>(string key)
        {
            if (!PropertyExists(key))
            {
                return default;
            }

            if (_appSettings[key] is JObject)
            {
                return ((JObject)_appSettings[key]).ToObject<T>();
            }
            return (T)_appSettings[key];
        }

        public void AddPropertyIfNotExists(string key, object value)
        {
            if (PropertyExists(key))
            {
                return;
            }
            
            if (value is bool b)
            {
                _appSettings[key] = b;
            }
            else if (value is int i)
            {
                _appSettings[key] = i;
            }
            else if(value is string s)
            {
                _appSettings[key] = s;
            }
            else
            {
                _appSettings[key] = JObject.FromObject(value);
            }
        }

        public void SetProperty(string key, string value)
        {
            _appSettings[key] = value;
        }

        public void SetProperty(string key, object value)
        {
            _appSettings[key] = JObject.FromObject(value);
        }
    }
}
