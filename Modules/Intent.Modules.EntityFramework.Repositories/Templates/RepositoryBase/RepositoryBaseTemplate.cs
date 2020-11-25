﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Repositories.Templates.RepositoryBase
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
    
    #line 1 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class RepositoryBaseTemplate : CSharpTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Data.Entity;\r\nusin" +
                    "g System.Linq;\r\nusing System.Linq.Expressions;\r\nusing System.Threading;\r\nusing S" +
                    "ystem.Threading.Tasks;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamesp" +
                    "ace ");
            
            #line 24 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("<TDomain, TPersistence, TDbContext> : ");
            
            #line 26 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RepositoryInterfaceName));
            
            #line default
            #line hidden
            this.Write("<TDomain, TPersistence>\r\n        where TDbContext : DbContext\r\n        where TPer" +
                    "sistence : class, TDomain\r\n        where TDomain : class\r\n    {\r\n        private" +
                    " readonly TDbContext _dbContext;\r\n\r\n        public ");
            
            #line 33 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(TDbContext dbContext)\r\n        {\r\n            _dbContext = dbContext ?? throw ne" +
                    "w ArgumentNullException(nameof(dbContext));\r\n        }\r\n\r\n        public virtual" +
                    " void Remove(TDomain entity)\r\n        {\r\n            GetSet().Remove((TPersisten" +
                    "ce)entity);\r\n        }\r\n\r\n        public virtual void Add(TDomain entity)\r\n     " +
                    "   {\r\n            GetSet().Add((TPersistence)entity);\r\n        }\r\n\r\n        publ" +
                    "ic Task<int> SaveChangesAsync()\r\n        {\r\n            return _dbContext.SaveCh" +
                    "angesAsync();\r\n        }\r\n\r\n        public Task<int> SaveChangesAsync(Cancellati" +
                    "onToken cancellationToken)\r\n        {\r\n            return _dbContext.SaveChanges" +
                    "Async(cancellationToken);\r\n        }\r\n\r\n        public virtual async Task<TDomai" +
                    "n> FindAsync(Expression<Func<TPersistence, bool>> filterExpression)\r\n        {\r\n" +
                    "            return await QueryInternal(filterExpression).SingleOrDefaultAsync<TD" +
                    "omain>();\r\n        }\r\n\r\n        public virtual async Task<List<TDomain>> FindAll" +
                    "Async()\r\n        {\r\n            return await QueryInternal(x => true).ToListAsyn" +
                    "c<TDomain>();\r\n        }\r\n        \r\n        public virtual async Task<List<TDoma" +
                    "in>> FindAllAsync(Expression<Func<TPersistence, bool>> filterExpression)\r\n      " +
                    "  {\r\n            return await QueryInternal(filterExpression).ToListAsync<TDomai" +
                    "n>();\r\n        }\r\n\r\n        public virtual async Task<List<TDomain>> FindAllAsyn" +
                    "c(Expression<Func<TPersistence, bool>> filterExpression, Func<IQueryable<TPersis" +
                    "tence>, IQueryable<TPersistence>> linq)\r\n        {\r\n            return await Que" +
                    "ryInternal(filterExpression, linq).ToListAsync<TDomain>();\r\n        }\r\n\r\n       " +
                    " public virtual async Task<IPagedResult<TDomain>> FindAllAsync(int pageNo, int p" +
                    "ageSize)\r\n        {\r\n            var query = QueryInternal(x => true);\r\n        " +
                    "    return await ");
            
            #line 81 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PagedListClassName));
            
            #line default
            #line hidden
            this.Write(@"<TDomain>.CreateAsync(
                query,
                pageNo,
                pageSize);
        }
        
        public virtual async Task<IPagedResult<TDomain>> FindAllAsync(Expression<Func<TPersistence, bool>> filterExpression, int pageNo, int pageSize)
        {
            var query = QueryInternal(filterExpression);
            return await ");
            
            #line 90 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PagedListClassName));
            
            #line default
            #line hidden
            this.Write(@"<TDomain>.CreateAsync(
                query,
                pageNo,
                pageSize);
        }

        public virtual async Task<IPagedResult<TDomain>> FindAllAsync(Expression<Func<TPersistence, bool>> filterExpression, int pageNo, int pageSize, Func<IQueryable<TPersistence>, IQueryable<TPersistence>> linq)
        {
            var query = QueryInternal(filterExpression, linq);
            return await ");
            
            #line 99 "C:\Dev\Intent.Modules.NET\Modules\Intent.Modules.EntityFramework.Repositories\Templates\RepositoryBase\RepositoryBaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PagedListClassName));
            
            #line default
            #line hidden
            this.Write("<TDomain>.CreateAsync(\r\n                query,\r\n                pageNo,\r\n        " +
                    "        pageSize);\r\n        }\r\n\r\n        public virtual async Task<int> CountAsy" +
                    "nc(Expression<Func<TPersistence, bool>> filterExpression)\r\n        {\r\n          " +
                    "  return await QueryInternal(filterExpression).CountAsync();\r\n        }\r\n\r\n     " +
                    "   public bool Any(Expression<Func<TPersistence, bool>> filterExpression)\r\n     " +
                    "   {\r\n            return QueryInternal(filterExpression).Any();\r\n        }\r\n\r\n  " +
                    "      public virtual async Task<bool> AnyAsync(Expression<Func<TPersistence, boo" +
                    "l>> filterExpression)\r\n        {\r\n            return await QueryInternal(filterE" +
                    "xpression).AnyAsync();\r\n        }\r\n\r\n        protected virtual IQueryable<TPersi" +
                    "stence> QueryInternal(Expression<Func<TPersistence, bool>> filterExpression)\r\n  " +
                    "      {\r\n            var queryable = CreateQuery();\r\n            if (filterExpre" +
                    "ssion != null)\r\n            {\r\n                queryable = queryable.Where(filte" +
                    "rExpression);\r\n            }\r\n            return queryable;\r\n        }\r\n\r\n      " +
                    "  protected virtual IQueryable<TResult> QueryInternal<TResult>(Expression<Func<T" +
                    "Persistence, bool>> filterExpression, Func<IQueryable<TPersistence>, IQueryable<" +
                    "TResult>> linq)\r\n        {\r\n            var queryable = CreateQuery();\r\n        " +
                    "    queryable = queryable.Where(filterExpression);\r\n\r\n            var result = l" +
                    "inq(queryable);\r\n            return result;\r\n        }\r\n\r\n        protected virt" +
                    "ual IQueryable<TPersistence> CreateQuery()\r\n        {\r\n            return GetSet" +
                    "();\r\n        }\r\n\r\n        protected virtual DbSet<TPersistence> GetSet()\r\n      " +
                    "  {\r\n            return _dbContext.Set<TPersistence>();\r\n        }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}