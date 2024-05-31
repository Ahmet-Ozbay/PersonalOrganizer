using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ReminderObserver : IReminderObserver
    {
        public void Update(IReminder reminder)
        {
            // Aktif pencerenin başlığını değiştir
            ChangeActiveWindowTitle(reminder.Description);

            // Aktif pencereyi salla
            ShakeActiveWindow();
        }
        

        private void ChangeActiveWindowTitle(string title)
        {
            // Aktif pencerenin başlığını değiştirme işlemi
        }

        private void ShakeActiveWindow()
        {
            // Aktif pencereyi sallama işlemi
        }
    }
}
