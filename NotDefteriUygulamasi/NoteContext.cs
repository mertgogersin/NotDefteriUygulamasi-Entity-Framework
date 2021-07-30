using NotDefteriUygulamasi.Entities;
using NotDefteriUygulamasi.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi
{
    public class NoteContext : DbContext
    {
       private static NoteContext instance;
        private NoteContext() : base("connectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<NoteContext>());
        }
        public static NoteContext GetInstance()
        {
            if(instance==null)
            {
                return new NoteContext();
            }
            return instance;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NoteMapping());

            modelBuilder.Configurations.Add(new UserMapping());

            modelBuilder.Configurations.Add(new UserPasswordMapping());
        }
    }
}
