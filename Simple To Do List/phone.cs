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
        private string topic;

        private Phone(DateTime dateTime, int twho, string topic)
        {
            this.dateTime = dateTime;
            this.twho = Contact.ContactList[twho].ToString();
            this.topic = topic;
        }

        public static void AddPhone(DateTime dateTime, int twho, string place)
        {
            try
            {
                Activity.ActivitiesList.Add(new Phone(dateTime, twho, place));
                SaveLoad.Save("activites.dat", Activity.ActivitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }

    }
}
