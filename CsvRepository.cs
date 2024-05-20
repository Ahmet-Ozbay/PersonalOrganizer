using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject
{
    internal class CsvRepository : IDataRepository
    {
        private string _userFilePath = "user_db.csv";
        private string _notesFilePath = "note_db.csv";
        private int _nextUserId;
        private int _nextNoteId;
        
        public CsvRepository() {

            // User DB Access
            if (File.Exists(_userFilePath))
            {
                List<User> users = List();
                _nextUserId = users.Any() ? users.Max(u => u.ID) + 1 : 1;
            } else
            {
                using (StreamWriter sw = File.CreateText(_userFilePath))
                {
                    sw.WriteLine("ID,EMAIL,PASSWORD,NAME,LASTNAME,AUTHORITY,PHONENUMBER,ADDRESS,SALARY");
                }

                _nextUserId = 1;
            }

            // Note DB Access
            if (File.Exists(_notesFilePath))
            {
                List<Note> notes = ListNotes();
                _nextNoteId = notes.Any() ? notes.Max(n => n.ID) + 1 : 1;
            }
            else
            {
                using (StreamWriter sw = File.CreateText(_notesFilePath))
                {
                    sw.WriteLine("ID,TITLE,CONTENT");
                }
                _nextNoteId = 1;
            }
        }

        /*
         * Create new User
         */
        public bool Add(User user)
        {
            try
            {
                // Yeni kullanıcı için bir ID atayın.
                user.ID = _nextUserId++;
                var line = $"{user.ID},{user.Email},{user.Password},{user.Name},{user.LastName}," +
                           $"{user.Authorisation},{user.PhoneNumber},{user.Address},{user.Salary}";

                // Kullanıcı bilgilerini dosyaya ekleyin.
                using (StreamWriter sw = File.AppendText(_userFilePath))
                {
                    sw.WriteLine(line);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Create new Note
         */
        public bool Add(Note note)
        {
            try
            {
                note.ID = _nextNoteId++;
                var encodedContent = EncodeToBase64(note.Content);
                var line = $"{note.ID},{note.UserEmail},{EscapeForCsv(note.Title)},{encodedContent}";
                using (StreamWriter sw = File.AppendText(_notesFilePath))
                {
                    sw.WriteLine(line);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Delete user
         */
        public bool Delete(User user)
        {
            try
            {
                var users = List();
                var userToDelete = users.FirstOrDefault(u => u.Email == user.Email);
                if (userToDelete != null)
                {
                    users.Remove(userToDelete);
                    WriteAllUsers(users);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Delete Note
         */
        public bool Delete(Note note)
        {
            try
            {
                var notes = ListNotes();
                var noteToDelete = notes.FirstOrDefault(n => n.ID == note.ID);
                if (noteToDelete != null)
                {
                    notes.Remove(noteToDelete);
                    WriteAllNotes(notes);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Read Users
         */
        public List<User> List()
        {
            try
            {
                return File.ReadAllLines(_userFilePath)
                    .Skip(1) // Başlık satırını atla.
                    .Select(line => FromCsv(line))
                    .ToList();
            }
            catch
            {
                return new List<User>();
            }
        }

        /*
         * Read Notes
         */
        public List<Note> ListNotes()
        {
            try
            {
                return File.ReadAllLines(_notesFilePath)
                    .Skip(1) // Skip the header line.
                    .Select(line => FromCsvToNote(line))
                    .ToList();
            }
            catch
            {
                return new List<Note>();
            }
        }

        /*
         * Get the user data from the database
         */
        private User FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new User
            {
                ID = Convert.ToInt32(values[0]),
                Email = values[1],
                Password = values[2],
                Name = values[3],
                LastName = values[4],
                Authorisation = (Authority)Enum.Parse(typeof(Authority), values[5]),
                PhoneNumber = values.Length > 6 ? values[6] : null,
                Address = values.Length > 7 ? values[7] : null,
                Salary = Convert.ToDouble(values[8])
            };
        }

        /*
         * Get the notebook data from the database
         */
        private Note FromCsvToNote(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Note
            {
                ID = Convert.ToInt32(values[0]),
                UserEmail = values[1],
                Title = UnescapeFromCsv(values[2]),
                Content = DecodeFromBase64(values[3])
            };
        }

        /*
         * Update the user
         */
        public bool Update(User user)
        {
            try
            {
                var users = List();
                var userToUpdate = users.FirstOrDefault(u => u.ID == user.ID);
                if (userToUpdate != null)
                {
                    userToUpdate.Email = user.Email;
                    userToUpdate.Password = user.Password;
                    userToUpdate.Name = user.Name;
                    userToUpdate.LastName = user.LastName;
                    userToUpdate.Authorisation = user.Authorisation;
                    userToUpdate.PhoneNumber = user.PhoneNumber;
                    userToUpdate.Address = user.Address;
                    userToUpdate.Salary = user.Salary;
                    WriteAllUsers(users);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Update notes
         */
        public bool Update(Note note)
        {
            try
            {
                var notes = ListNotes();
                var noteToUpdate = notes.FirstOrDefault(n => n.ID == note.ID);
                if (noteToUpdate != null)
                {
                    noteToUpdate.Title = note.Title;
                    noteToUpdate.Content = note.Content;
                    WriteAllNotes(notes); // This will re-encode all notes
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Write all users to db
         */
        private void WriteAllUsers(List<User> users)
        {
            using (StreamWriter sw = File.CreateText(_userFilePath))
            {
                sw.WriteLine("ID,EMAIL,PASSWORD,NAME,LASTNAME,AUTHORITY,PHONENUMBER,ADDRESS,SALARY");
                foreach (var user in users)
                {
                    var line = $"{user.ID},{user.Email},{user.Password},{user.Name},{user.LastName}," +
                               $"{user.Authorisation},{user.PhoneNumber},{user.Address},{user.Salary}";
                    sw.WriteLine(line);
                }
            }
        }

        /*
         * Write all notes to db
         */
        private void WriteAllNotes(List<Note> notes)
        {
            using (StreamWriter sw = File.CreateText(_notesFilePath))
            {
                sw.WriteLine("ID,USEREMAIL,TITLE,CONTENT");
                foreach (var note in notes)
                {
                    var encodedContent = EncodeToBase64(note.Content);
                    var line = $"{note.ID},{note.UserEmail},{EscapeForCsv(note.Title)},{encodedContent}";
                    sw.WriteLine(line);
                }
            }
        }

        // Helper methods for Base64 encoding/decoding and CSV escaping
        private string EncodeToBase64(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        private string DecodeFromBase64(string base64Input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(base64Input));
        }

        private string EscapeForCsv(string input)
        {
            if (input.Contains(",") || input.Contains("\""))
            {
                return $"\"{input.Replace("\"", "\"\"")}\"";
            }
            else
            {
                return input;
            }
        }

        private string UnescapeFromCsv(string input)
        {
            if (input.StartsWith("\"") && input.EndsWith("\""))
            {
                return input.Substring(1, input.Length - 2).Replace("\"\"", "\"");
            }
            else
            {
                return input;
            }
        }

    }
}
