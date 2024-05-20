using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class NoteBook
    {
        private User Owner { get; set; }
        private List<Note> Notes { get; set; }
        private IDataRepository _repository { get; set; }

        public NoteBook(IDataRepository repository)
        {
            _repository = repository;
            Notes = _repository.ListNotes(); // Load notes from the repository.
        }

        public bool Add(Note note)
        {
            // Add the note to the repository.
            var result = _repository.Add(note);
            if (result)
            {
                Notes.Add(note); // Add the note to the local list if successful.
            }
            return result;
        }

        public bool Update(Note note)
        {
            // Update the note in the repository.
            var result = _repository.Update(note);
            if (result)
            {
                // Update the note in the local list.
                var noteToUpdate = Notes.FirstOrDefault(n => n.ID == note.ID);
                if (noteToUpdate != null)
                {
                    noteToUpdate.Title = note.Title;
                    noteToUpdate.Content = note.Content;
                }
            }
            return result;
        }

        public bool Delete(Note note)
        {
            // Delete the note from the repository.
            var result = _repository.Delete(note);
            if (result)
            {
                // Remove the note from the local list.
                Notes.RemoveAll(n => n.ID == note.ID);
            }
            return result;
        }

        public List<Note> List()
        {
          return _repository.ListNotes(); // Return the local list of notes.
        }
    }
}
