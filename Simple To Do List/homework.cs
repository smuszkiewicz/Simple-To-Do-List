using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    [Serializable]
    class Homework : Activity
    {
        private static List<string> subjects = new List<string>();
        private string subject;

        private Homework(DateTime dateTime, int type)
        {
            this.dateTime = dateTime;
            this.subject = subjects[type];
        }

        public static List<string> Subjects { get => subjects; set => subjects = value; }

        public static void AddHomework(DateTime dateTime, int type)
        {
            try
            {
                Activity.ActivitiesList.Add(new Homework(dateTime, type));
                SaveLoad.Save("activites.dat", Activity.ActivitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }
        public static void AddSubject(string subject)
        {
            try
            {
                Homework.subjects.Add(subject);
                SaveLoad.Save("subjects.dat", subjects);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }

    }
}
