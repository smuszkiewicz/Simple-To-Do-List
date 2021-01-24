using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Phone : Activity
    {
        private string twho;

        private Phone(DateTime dateTime, int twho, string note)
        {
            this.dateTime = dateTime;
            this.twho = Contact.ContactList[twho].ToString();
            this.note = note;
        }

        public static void AddPhone(DateTime dateTime, int twho, string note)
        {
            try
            {
                Activity.ActivitiesList.Add(new Phone(dateTime, twho, note));
                SaveLoad.Save("activites.dat", Activity.ActivitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }

    }
}
