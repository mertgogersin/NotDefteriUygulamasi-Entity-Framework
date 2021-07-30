using NotDefteriUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Mappings
{
    class UserPasswordMapping:EntityTypeConfiguration<UserPassword>
    {
        public UserPasswordMapping()
        {
            HasKey(x => x.ID).ToTable("UserPasswords");

            Property(x => x.Password)
                .IsRequired();

         
        }
    }
}
