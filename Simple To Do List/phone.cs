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

        public Phone(DateTime dateTime, int twho, string topic)
        {
            this.dateTime = dateTime;
            this.twho = Contact.contactList[twho];
            this.topic = topic;
        }

        public static void AddPhone(DateTime dateTime, int twho, string place)
        {
            Activity.ActivitiesList.Add(new Phone(dateTime, twho, place));
            Save("activites.dat", Activity.ActivitiesList);
        }

    }
}
