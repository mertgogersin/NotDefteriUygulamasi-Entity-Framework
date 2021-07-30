using NotDefteriUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Mappings
{
    class UserMapping:EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(x => x.UserID).ToTable("Users");

            Property(x => x.UserName)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_UserName",3) { IsUnique = true }));

            Property(x => x.Name)
                .IsRequired();


            Property(x => x.SurName)
                .IsRequired();
                

            Property(x => x.Password)
                .IsRequired();

        }
    }
}
