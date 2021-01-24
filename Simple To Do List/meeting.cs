using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Simple_To_Do_List
{
    [Serializable]
    class Meeting : Activity
    {
        private Contact wwho;

        private Meeting(DateTime dateTime, int wwho, string note)
        {
            this.dateTime = dateTime;
            this.wwho = Contact.ContactList[wwho];
            this.note = note;
        }

        public Contact Wwho { get => wwho; set => wwho = value; }

        public static void AddMeeting(DateTime dateTime, int wwho, string note)
        {
            Activity.ActivitiesList.Add(new Meeting(dateTime, wwho, note));
            Activity.ActivitiesList = new BindingList<Activity>(Activity.ActivitiesList.OrderBy(x => x.DateTime).ToList());
            SaveLoad.Save("activities.dat", Activity.ActivitiesList);
        }
        public override string ToString()
        {
            return dateTime.ToString("dd/MM/yyyy") + " Spotkanie z " + wwho.ToString();
        }
    }
}
