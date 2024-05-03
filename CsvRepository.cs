﻿using System;
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
        private string _filePath = "user_db.csv";
        private int _nextId;
        
        public CsvRepository() {

            if (File.Exists(_filePath))
            {
                List<User> users = List();
                _nextId = users.Any() ? users.Max(u => u.ID) + 1 : 1;
            } else
            {
                using (StreamWriter sw = File.CreateText(_filePath))
                {
                    sw.WriteLine("ID,EMAIL,PASSWORD,NAME,LASTNAME,AUTHORITY");
                }

                _nextId = 1;
            }
        }

        public bool Add(User user)
        {
            try
            {
                // Yeni kullanıcı için bir ID atayın.
                user.ID = _nextId++;
                var line = $"{user.ID},{user.Email},{user.Password},{user.Name},{user.LastName},{user.Authorisation}";

                // Kullanıcı bilgilerini dosyaya ekleyin.
                using (StreamWriter sw = File.AppendText(_filePath))
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
        public List<User> List()
        {
            try
            {
                return File.ReadAllLines(_filePath)
                    .Skip(1) // Başlık satırını atla.
                    .Select(line => FromCsv(line))
                    .ToList();
            }
            catch
            {
                return new List<User>();
            }
        }
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
                Authorisation = (Authority)Enum.Parse(typeof(Authority), values[5])
            };
        }
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

        private void WriteAllUsers(List<User> users)
        {
            using (StreamWriter sw = File.CreateText(_filePath))
            {
                sw.WriteLine("ID,EMAIL,PASSWORD,NAME,LASTNAME,AUTHORITY");
                foreach (var user in users)
                {
                    var line = $"{user.ID},{user.Email},{user.Password},{user.Name},{user.LastName},{user.Authorisation}";
                    sw.WriteLine(line);
                }
            }
        }
    }
}
