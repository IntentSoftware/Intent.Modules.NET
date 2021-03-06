﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Entities.Templates.DomainEntityInterface
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class DomainEntityInterfaceTemplate : CSharpTemplateBase<ClassModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\n\r\n[assembly: DefaultIntentManag" +
                    "ed(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 22 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceAnnotations(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n    public partial interface ");
            
            #line 23 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            
            #line 23 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetInterfaces(Model)));
            
            #line default
            #line hidden
            
            #line 23 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ParentClass != null ? string.Format(" : I{0}", Model.ParentClass.Name) : ""));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 25 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeProperties(Model)));
            
            #line default
            #line hidden
            
            #line 25 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
  foreach (var attribute in Model.Attributes)
    {

            
            #line default
            #line hidden
            
            #line 27 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyBefore(attribute)));
            
            #line default
            #line hidden
            
            #line 27 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"

        if (!CanWriteDefaultAttribute(attribute)) 
        {
            continue;
        }

            
            #line default
            #line hidden
            
            #line 32 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(attribute)));
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 33 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(attribute.Type)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 33 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" { ");
            
            #line 33 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AttributeAccessors(attribute)));
            
            #line default
            #line hidden
            this.Write(" }\r\n");
            
            #line 34 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
  }

    foreach (var associatedClass in Model.AssociatedClasses)
    {

            
            #line default
            #line hidden
            
            #line 38 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyBefore(associatedClass)));
            
            #line default
            #line hidden
            
            #line 38 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"

        if (!CanWriteDefaultAssociation(associatedClass) || !associatedClass.IsNavigable) 
        {
            continue;
        }

            
            #line default
            #line hidden
            
            #line 43 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(associatedClass)));
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 44 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(associatedClass)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 44 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" { ");
            
            #line 44 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationAccessors(associatedClass)));
            
            #line default
            #line hidden
            this.Write(" }\r\n");
            
            #line 45 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
  }
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 47 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
  foreach (var operation in Model.Operations)
    {
        if (!CanWriteDefaultOperation(operation)) 
        {
            continue;
        }
        string parameterDefinitions = operation.Parameters.Any() ? operation.Parameters.Select(x => Types.Get(x.TypeReference) + " " + x.Name.ToCamelCase()).Aggregate((x, y) => x + ", " + y) : "";
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 54 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EmitOperationReturnType(operation)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 54 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 54 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetParametersDefinition(operation)));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n");
            
            #line 56 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.Entities\Templates\DomainEntityInterface\DomainEntityInterfaceTemplate.tt"
  }
            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
