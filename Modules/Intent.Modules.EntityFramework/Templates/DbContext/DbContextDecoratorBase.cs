﻿using System.Collections.Generic;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Common;
using Intent.Templates;

namespace Intent.Modules.EntityFramework.Templates.DbContext
{
    public abstract class DbContextDecoratorBase : ITemplateDecorator
    {
        public virtual string GetBaseClass() { return null; }
            
        public virtual IEnumerable<string> GetMethods() { return new List<string>(); }

        public int Priority { get; set; } = 0;
    }
}