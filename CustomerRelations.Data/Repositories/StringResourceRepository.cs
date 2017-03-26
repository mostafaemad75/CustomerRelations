using CustomerRelations.Data.Infrastructure;
using CustomerRelations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelations.Data.Repositories
{
    public class StringResourceRepository : RepositoryBase<StringResource>, IStringResourceRepository
    {
        public StringResourceRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
        public IEnumerable<StringResource> GetCultureStringResources(string cultureCode)
        {
            return this.DbContext.StringResources.Where(x => x.cultureCode == cultureCode.Trim().ToLower());
        }
    }
    public interface IStringResourceRepository : IRepository<StringResource>
    {
        IEnumerable<StringResource> GetCultureStringResources(string cultureCode);
    }

}
