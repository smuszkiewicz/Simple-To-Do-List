using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Homework : Activity
    {
        static private List<string> subjects = new List<string>();
        private string subject;

        public Homework(DateTime dateTime, int type)
        {
            this.dateTime = dateTime;
            this.subject = subjects[type];
        }

        public static void AddHomework(DateTime dateTime, int type)
        {
            Activity.ActivitiesList.Add(new Duty(dateTime, type));
            Save("activites.dat", Activity.ActivitiesList);
        }

    }
}
