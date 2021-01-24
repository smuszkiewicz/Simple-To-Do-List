using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Simple_To_Do_List
{
    [Serializable]
    class Homework : Activity
    {
        private static BindingList<string> subjects = new BindingList<string>();
        private string subject;

        private Homework(DateTime dateTime, int type, string note)
        {
            this.dateTime = dateTime;
            this.subject = subjects[type];
            this.note = note;
        }

        public static BindingList<string> Subjects { get => subjects; set => subjects = value; }

        public static void AddHomework(DateTime dateTime, int type, string note)
        {
            try
            {
                Activity.ActivitiesList.Add(new Homework(dateTime, type, note));
                Activity.ActivitiesList = new BindingList<Activity>(Activity.ActivitiesList.OrderBy(x => x.DateTime).ToList());
                SaveLoad.Save("activities.dat", Activity.ActivitiesList);
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
        public static void RemoveSubject(int i)
        {
            try
            {
                subjects.RemoveAt(i);
                SaveLoad.Save("subjects.dat", subjects);
            }
            catch
            {
                throw new Exception("Nie udało się usunąć :<");
            }
        }
        public override string ToString()
        {
            return dateTime.ToString("dd/MM/yyyy") + " Praca domowa z " + subject;
        }

    }
}
