using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Duty : Activity
    {
        static private List<string> duties = new List<string>();
        private string type;

        public Duty(DateTime dateTime, int type)
        {
            this.dateTime = dateTime;
            this.type = duties[type];
        }

        public static void AddDuty(DateTime dateTime, int type)
        {
            Activity.ActivitiesList.Add(new Duty(dateTime, type));
            Save("activites.dat", Activity.ActivitiesList);
        }

    }
}
