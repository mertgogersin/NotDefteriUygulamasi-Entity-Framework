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
    class NoteMapping : EntityTypeConfiguration<Note>
    {
        public NoteMapping()
        {
            HasKey(x => x.NoteID).ToTable("Notes");

        }
    }
}
