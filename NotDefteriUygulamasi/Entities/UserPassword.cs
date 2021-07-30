using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Entities
{
    public class UserPassword
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Password { get; set; }
        public DateTime? VerifiedDate { get; set; }
    }
}
