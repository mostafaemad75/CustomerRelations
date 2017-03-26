using CustomerRelations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelations.Data.Configuration
{
    public class StringResourceConfiguration : EntityTypeConfiguration<StringResource>
    {
        public StringResourceConfiguration()
        {
            ToTable("StringResource");
            HasKey(g => new { g.cultureCode, g.resourceKey });
            Property(g => g.cultureCode).IsRequired().HasMaxLength(10);
            Property(g => g.resourceKey).IsRequired().HasMaxLength(500);
            Property(g => g.resourceValue).IsRequired().HasMaxLength(4000);
        }
    }
}
