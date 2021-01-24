using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Simple_To_Do_List
{
    [Serializable]
    class Duty : Activity
    {
        static private BindingList<string> dutiesTypes = new BindingList<string>();
        private string type;

        private Duty(DateTime dateTime, int type, string note)
        {
            this.dateTime = dateTime;
            this.type = dutiesTypes[type];
            this.note = note;
        }

        public static BindingList<string> DutiesTypes { get => dutiesTypes; set => dutiesTypes = value; }

        public static void AddDuty(DateTime dateTime, int type, string note)
        {
            try
            {
                Activity.ActivitiesList.Add(new Duty(dateTime, type, note));
                Activity.ActivitiesList = new BindingList<Activity>(Activity.ActivitiesList.OrderBy(x => x.DateTime).ToList());
                SaveLoad.Save("activities.dat", Activity.ActivitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }

        public static void AddDutyType(string type)
        {
            try
            {
                dutiesTypes.Add(type);
                SaveLoad.Save("dutiesTypes.dat", dutiesTypes);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }
        public static void RemoveDutyType(int i)
        {
            try
            {
                dutiesTypes.RemoveAt(i);
                SaveLoad.Save("dutiesTypes.dat", dutiesTypes);
            }
            catch
            {
                throw new Exception("Nie udało się usunąć :<");
            }
        }
        public override string ToString()
        {
            return dateTime.ToString("dd/MM/yyyy") + " " + type;
        }

    }
}
