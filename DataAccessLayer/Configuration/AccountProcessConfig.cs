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
    internal class AccountProcessConfig : IEntityTypeConfiguration<AccountProcess>
    {
        public void Configure(EntityTypeBuilder<AccountProcess> builder)
        {
            builder.Property(b => b.Type).HasColumnName("ProcessType").HasMaxLength(100);
            builder.Property(b => b.Date).HasDefaultValue(DateTime.Now);
        }
    }
}
