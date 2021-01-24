using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Meeting : Activity
    {
        private string wwho;

        private Meeting(DateTime dateTime, int wwho, string note)
        {
            this.dateTime = dateTime;
            this.wwho = Contact.ContactList[wwho].ToString();
            this.note = note;
        }

        public static void AddMeeting(DateTime dateTime, int wwho, string note)
        {
            Activity.ActivitiesList.Add(new Meeting(dateTime, wwho, note));
            SaveLoad.Save("activites.dat", Activity.ActivitiesList);
        }
    }
}
