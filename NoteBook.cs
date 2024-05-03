using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class NoteBook
    {
        private User Owner {  get; set; }
        private List<Note> Notes { get; set; }
        private IDataRepository _repository { get; set; }

        public NoteBook() { }
        public NoteBook(IDataRepository repository) { _repository = repository; }

        public bool Add(Note note) { throw new NotImplementedException(); }
        public bool Update(Note note) { throw new NotImplementedException(); }
        public bool Delete(Note note) { throw new NotImplementedException() ; }
        public List<Note> List() { throw new NotImplementedException(); }
    }
}
