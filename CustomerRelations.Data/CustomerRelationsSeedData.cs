using CustomerRelations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelations.Data
{
    public class CustomerRelationsSeedData : DropCreateDatabaseIfModelChanges<CustomerRelationsEntities>
    {
        protected override void Seed(CustomerRelationsEntities context)
        {
            GetStringResources().ForEach(c => context.StringResources.Add(c));
            context.Commit();
        }
        private static List<StringResource> GetStringResources()
        {
            return new List<StringResource>
            {
                new StringResource {
                    cultureCode = "en",
                    resourceKey = "test",
                    resourceValue = "test"
                },
            };
        }
    }
}
