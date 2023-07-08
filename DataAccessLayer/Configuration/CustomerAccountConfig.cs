using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    internal class CustomerAccountConfig : IEntityTypeConfiguration<CustomerAccount>
    {
        public void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Currency).HasMaxLength(50);
            builder.Property(b => b.CreationDate).HasDefaultValue(DateTime.Now);
        }
    }
}
