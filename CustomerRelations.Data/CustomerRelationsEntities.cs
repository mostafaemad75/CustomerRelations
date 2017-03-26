using CustomerRelations.Data.Configuration;
using CustomerRelations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelations.Data
{
    public class CustomerRelationsEntities : DbContext
    {
        public CustomerRelationsEntities() : base("CustomerRelationsEntities") { }

        public DbSet<StringResource> StringResources { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StringResourceConfiguration());
        }
    }
}
