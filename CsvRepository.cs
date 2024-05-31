using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject
{
    internal class CsvRepository : IDataRepository
    {
        private string _userFilePath = "user_db.csv";
        private string _notesFilePath = "note_db.csv";
        private string _contactsFilePath = "contacts_db.csv";
        private string _remindersFilePath = "reminders_db.csv";
        private IReminderFactory _reminderFactory;
        private int _nextUserId;
        private int _nextNoteId;
        private int _nextContactId;
        private int _nextReminderId;

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

            // Contact DB Access
            if (!File.Exists(_contactsFilePath) || new FileInfo(_contactsFilePath).Length == 0)
            {
                using (StreamWriter sw = File.CreateText(_contactsFilePath))
                {
                    sw.WriteLine("ID,UserEmail,Name,LastName,PhoneNumber,Email,Address");
                }
            }
        }

        public CsvRepository(IReminderFactory reminderFactory)
        {
            // Reminder DB Access
            _reminderFactory = reminderFactory;

            if (File.Exists(_remindersFilePath))
            {
                List<IReminder> reminders = ListReminders();
                _nextReminderId = reminders.Any() ? reminders.Max(r => r.ID) + 1 : 1;
            }
            else
            {
                using (StreamWriter sw = File.CreateText(_remindersFilePath))
                {
                    sw.WriteLine("ID,USEREMAIL,TITLE,SUMMARY,DESCRIPTION,STARTDATE,ENDDATE");
                }
                _nextReminderId = 1;
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
         * Create new Contact
         */
        public bool Add(Contact contact)
        {
            try
            {
                contact.ID = _nextContactId++;
                var line = $"{contact.ID},{contact.UserEmail},{EscapeForCsv(contact.Name)},{EscapeForCsv(contact.LastName)}," +
                           $"{EscapeForCsv(contact.PhoneNumber)},{EscapeForCsv(contact.Email)},{EscapeForCsv(contact.Address)}";
                using (StreamWriter sw = File.AppendText(_contactsFilePath))
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
         * Create new Reminder
        */
        public bool Add(IReminder reminder)
        {
            try
            {
                reminder.ID = _nextReminderId++;
                var line = new StringBuilder();
                line.Append(reminder.ID + ",");
                line.Append(EscapeForCsv(reminder.UserEmail) + ",");
                line.Append(EscapeForCsv(reminder.Title) + ",");
                line.Append(EscapeForCsv(reminder.Summary) + ",");
                line.Append(EscapeForCsv(reminder.Description) + ",");
                line.Append(EscapeForCsv(reminder.StartDate.ToString("o")) + ",");
                line.Append(EscapeForCsv(reminder.EndDate.ToString("o")));

                using (StreamWriter sw = File.AppendText(_remindersFilePath))
                {
                    sw.WriteLine(line.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding reminder: {ex.Message}");
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
         * Delete Contact
         */
        public bool Delete(Contact contact)
        {
            try
            {
                var contacts = ListContacts(contact.UserEmail);
                var contactToDelete = contacts.FirstOrDefault(c => c.ID == contact.ID);
                if (contactToDelete != null)
                {
                    contacts.Remove(contactToDelete);
                    WriteAllContacts(contacts); // Rewrite the updated list to the CSV file
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
         * Delete reminders
         */
        public bool Delete(IReminder reminder)
        {
            try
            {
                var reminders = ListReminders().ToList();
                var reminderToDelete = reminders.FirstOrDefault(r => r.ID == reminder.ID);
                if (reminderToDelete != null)
                {
                    reminders.Remove(reminderToDelete);
                    WriteAllReminders(reminders);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the reminder: " + ex.Message);
                return false;
            }
        }


        public List<IReminder> ListReminders()
        {
            var reminders = new List<IReminder>();
            if (File.Exists(_remindersFilePath))
            {
                var lines = File.ReadAllLines(_remindersFilePath).Skip(1); // Skip header line
                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    IReminder reminder = CreateReminderFromValues(values);
                    reminders.Add(reminder);
                }
            }
            return reminders;
        }

        private IReminder CreateReminderFromValues(string[] values)
        {
            IReminder reminder;
            string title = values[2];

            if (title == "Meeting")
            {
                reminder = _reminderFactory.CreateMeetingReminder();
            }
            else
            {
                reminder = _reminderFactory.CreateTaskReminder();
            }

            reminder.ID = int.Parse(values[0]);
            reminder.UserEmail = values[1];
            reminder.Title = values[2];
            reminder.Summary = values[3];
            reminder.Description = values[4];
            reminder.StartDate = DateTime.Parse(values[5]);
            reminder.EndDate = DateTime.Parse(values[6]);

            return reminder;
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
         * Read Contacts
         */
        public List<Contact> ListContacts(string userEmail)
        {
            try
            {
                return File.ReadAllLines(_contactsFilePath)
                    .Skip(1)
                    .Select(line => FromCsvToContact(line))
                    .Where(contact => contact.UserEmail == userEmail)
                    .ToList();
            }
            catch
            {
                return new List<Contact>();
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
         * Get the contact data from the database
         */
        private Contact FromCsvToContact(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Contact
            {
                ID = Convert.ToInt32(values[0]),
                UserEmail = values[1],
                Name = UnescapeFromCsv(values[2]),
                LastName = UnescapeFromCsv(values[3]),
                PhoneNumber = UnescapeFromCsv(values[4]),
                Email = UnescapeFromCsv(values[5]),
                Address = UnescapeFromCsv(values[6])
            };
        }
        /*
        * Get the reminder data from the database
        */
        private IReminder FromCsvToReminder(string csvLine)
        {
            var values = csvLine.Split(new char[] { ',' }, StringSplitOptions.None);
            string reminderType = UnescapeFromCsv(values[2]); 

            IReminder reminder;
            if (reminderType == "Meeting")
            {
                reminder = new MeetingReminder();
            }
            else if (reminderType == "Task")
            {
                reminder = new TaskReminder();
            }
            else
            {
                throw new InvalidOperationException("Unknown reminder type.");
            }

            reminder.ID = Convert.ToInt32(values[0]);
            reminder.UserEmail = UnescapeFromCsv(values[1]);
            reminder.Title = reminderType;
            reminder.Summary = UnescapeFromCsv(values[3]);
            reminder.Description = UnescapeFromCsv(values[4]);
            reminder.StartDate = DateTime.ParseExact(UnescapeFromCsv(values[5]), "o", CultureInfo.InvariantCulture);
            reminder.EndDate = DateTime.ParseExact(UnescapeFromCsv(values[6]), "o", CultureInfo.InvariantCulture);


            return reminder;
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
         * Update contacts
         */
        public bool Update(Contact contact)
        {
            try
            {
                var contacts = ListContacts(contact.UserEmail);
                var contactToUpdate = contacts.FirstOrDefault(c => c.Email == contact.Email);
                if (contactToUpdate != null)
                {
                    contactToUpdate.Name = contact.Name;
                    contactToUpdate.LastName = contact.LastName;
                    contactToUpdate.PhoneNumber = contact.PhoneNumber;
                    contactToUpdate.Address = contact.Address;
                    WriteAllContacts(contacts);
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
        * Update reminders
        */
        public bool Update(IReminder reminder)
        {
            try
            {
                var reminders = ListReminders().ToList();
                var index = reminders.FindIndex(r => r.ID == reminder.ID);
                if (index != -1)
                {
                    reminders[index] = reminder;
                    WriteAllReminders(reminders);
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

        /* 
         * Write all contacts to db
         */
        private void WriteAllContacts(List<Contact> contacts)
        {
            using (StreamWriter sw = new StreamWriter(_contactsFilePath, false)) // Overwrite the file
            {
                sw.WriteLine("ID,UserEmail,Name,LastName,PhoneNumber,Email,Address"); // Write the header
                foreach (var contact in contacts)
                {
                    var line = $"{contact.ID},{contact.UserEmail},{EscapeForCsv(contact.Name)}," +
                               $"{EscapeForCsv(contact.LastName)},{EscapeForCsv(contact.PhoneNumber)}," +
                               $"{EscapeForCsv(contact.Email)},{EscapeForCsv(contact.Address)}";
                    sw.WriteLine(line);
                }
            }
        }

        /* 
        * Write all contacts to db
        */
        private void WriteAllReminders(List<IReminder> reminders)
        {
            using (StreamWriter sw = File.CreateText(_remindersFilePath))
            {
                sw.WriteLine("ID,USEREMAIL,TITLE,SUMMARY,DESCRIPTION,STARTDATE,ENDDATE");
                foreach (var reminder in reminders)
                {
                    var line = new StringBuilder();
                    line.Append(reminder.ID + ",");
                    line.Append(EscapeForCsv(reminder.UserEmail) + ",");
                    line.Append(EscapeForCsv(reminder.Title) + ",");
                    line.Append(EscapeForCsv(reminder.Summary) + ",");
                    line.Append(EscapeForCsv(reminder.Description) + ",");
                    line.Append(EscapeForCsv(reminder.StartDate.ToString("o")) + ",");
                    line.Append(EscapeForCsv(reminder.EndDate.ToString("o")));
                    

                    sw.WriteLine(line.ToString());
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

        private string EscapeForCsv(object input)
        {
            if (input == null) return "";

            string inputAsString = input is DateTime dateTime ? dateTime.ToString("o") : input.ToString();

            if (inputAsString.Contains(",") || inputAsString.Contains("\""))
            {
                return $"\"{inputAsString.Replace("\"", "\"\"")}\"";
            }
            else
            {
                return inputAsString;
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
