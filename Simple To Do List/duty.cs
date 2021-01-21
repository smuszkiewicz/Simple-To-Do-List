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

        private Duty(DateTime dateTime, int type)
        {
            this.dateTime = dateTime;
            this.type = duties[type];
        }

        public static void AddDuty(DateTime dateTime, int type)
        {
            try
            {
                Activity.ActivitiesList.Add(new Duty(dateTime, type));
                SaveLoad.Save("activites.dat", Activity.ActivitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }

    }
}
