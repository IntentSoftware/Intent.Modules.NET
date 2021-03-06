﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFrameworkCore.Repositories.Templates.Repository
{
    using Intent.Modelers.Domain.Api;
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class RepositoryTemplate : CSharpTemplateBase<ClassModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Linq;\r\nusing System.Threading;\r\nusing System.Threadin" +
                    "g.Tasks;\r\nusing System.Collections.Generic;\r\nusing Microsoft.EntityFrameworkCore" +
                    ";\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 23 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge)]\r\n    public class ");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : RepositoryBase<");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityInterfaceName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextName));
            
            #line default
            #line hidden
            this.Write(">, ");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RepositoryContractName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public ");
            
            #line 28 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 28 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextName));
            
            #line default
            #line hidden
            this.Write(" dbContext) : base (dbContext)\r\n        {\r\n        }\r\n\r\n        public async Task" +
                    "<");
            
            #line 32 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityInterfaceName));
            
            #line default
            #line hidden
            this.Write("> FindByIdAsync(");
            
            #line 32 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryKeyType));
            
            #line default
            #line hidden
            this.Write(" id, CancellationToken cancellationToken = default)\r\n        {\r\n            retur" +
                    "n await FindAsync(x => x.");
            
            #line 34 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryKeyName));
            
            #line default
            #line hidden
            this.Write(" == id, cancellationToken);\r\n        }\r\n\r\n        public async Task<List<");
            
            #line 37 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityInterfaceName));
            
            #line default
            #line hidden
            this.Write(">> FindByIdsAsync(");
            
            #line 37 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryKeyType));
            
            #line default
            #line hidden
            this.Write("[] ids, CancellationToken cancellationToken = default)\r\n        {\r\n            re" +
                    "turn await FindAllAsync(x => ids.Contains(x.");
            
            #line 39 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFrameworkCore.Repositories\Templates\Repository\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryKeyName));
            
            #line default
            #line hidden
            this.Write("), cancellationToken);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
