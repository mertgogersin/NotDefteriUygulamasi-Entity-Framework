using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Entities
{
   public class User
    {
        
        public int UserID { get; set; }
       
        public string Name { get; set; }
  
        public string SurName { get; set; }
 
        public string UserName { get; set; }
   
        public string Password { get; set; }
        public bool IsVerified { get; set; } = false; //default value
        public ICollection<UserPassword> UserPasswords { get; set; }
        public ICollection<Note> Notes { get; set; }
        
    }
}
