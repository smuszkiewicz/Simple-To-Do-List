using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Duty : Activity
    {
        static private List<string> dutiesTypes = new List<string>();
        private string type;

        private Duty(DateTime dateTime, int type, string note)
        {
            this.dateTime = dateTime;
            this.type = dutiesTypes[type];
            this.note = note;
        }

        public static List<string> DutiesTypes { get => dutiesTypes; set => dutiesTypes = value; }

        public static void AddDuty(DateTime dateTime, int type, string note)
        {
            try
            {
                Activity.ActivitiesList.Add(new Duty(dateTime, type, note));
                SaveLoad.Save("activites.dat", Activity.ActivitiesList);
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

    }
}
