﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.Engine;
using Intent.Modelers.Services;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common.Registrations;
using Intent.Templates;

namespace Intent.Modules.Application.Contracts.Mappings.Templates.Mapping
{
    [Description(MappingTemplate.Identifier)]
    public class MappingTemplateRegistrations : FilePerModelTemplateRegistration<DTOModel>
    {
        private readonly IMetadataManager _metadataManager;

        public MappingTemplateRegistrations(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => MappingTemplate.Identifier;

        public override ITemplate CreateTemplateInstance(IOutputTarget project, DTOModel model)
        {
            return new MappingTemplate(project, model);
        }

        public override IEnumerable<DTOModel> GetModels(IApplication application)
        {
            return _metadataManager.Services(application).GetDTOModels().Where(x => x.Mapping != null).ToList();
        }
    }
}
