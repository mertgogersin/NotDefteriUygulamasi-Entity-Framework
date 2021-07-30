using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Entities
{
    public class Note
    {
        public int NoteID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

        public string Header { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Header;
        }
    }
}
