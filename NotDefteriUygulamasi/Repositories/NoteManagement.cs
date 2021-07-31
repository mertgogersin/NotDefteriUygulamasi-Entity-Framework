using NotDefteriUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Repositories
{
    class NoteManagement
    {
        public NoteManagement()
        {
            dbContext = NoteContext.GetInstance();
        }
        NoteContext dbContext;
        public void AddNote(User user, string _header, string _description)
        {
            if (_header == "") //description is nullable
            {
                throw new Exception("Başlık boş olamaz.");
            }
            foreach (Note item in GetNotesByUserID(user.UserID))
            {
                if (item.Header == _header)
                {
                    throw new Exception("Aynı başlıkta bir notunuz bulunmaktadır.");
                }
            }
            Note note = new Note()
            {
                UserID = user.UserID,
                Header = _header,
                Description = _description,
            };
            dbContext.Notes.Add(note);
            dbContext.SaveChanges();


        }
        public void DeleteNote(int noteID)
        {
            Note note = dbContext.Notes.Find(noteID); //Direkt note class'ını parametre olarak attığımda EF, class'ın database'den ayrı olarak çalıştığını görüyor. O yüzden bu yöntem ile çözüme ulaştım.
            if (note == null)
                throw new Exception("Bir hata oluştu.");

            dbContext.Notes.Remove(note);
            dbContext.SaveChanges();
        }
        public void UpdateNote(Note note, string _header, string _description)
        {
            foreach (Note item in GetNotesByUserID(note.UserID))
            {
                if (item.Header != note.Header && item.Header == _header)
                {
                    throw new Exception("Aynı başlıkta bir notunuz bulunmaktadır.");
                }
            }
            note.Header = _header;
            note.Description = _description;
            dbContext.SaveChanges();
        }
        List<Note> notes =new List<Note>();
        public List<Note> GetNotesByUserID(int userID)
        {           
            notes=dbContext.Notes.Where(x => x.UserID == userID).ToList();
            return notes;
        }
    }
}
