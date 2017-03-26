using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelations.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        CustomerRelationsEntities dbContext;

        public CustomerRelationsEntities Init()
        {
            return dbContext ?? (dbContext = new CustomerRelationsEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
