using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Simple_To_Do_List
{
    [Serializable]
    abstract class Activity
    {
        protected DateTime dateTime;
        private static List<Activity> activitiesList = new List<Activity>();
        private static List<Type> typesOfActivities = new List<Type>
        {
            new Type() {Name = nameof(Meeting), PolishName = "Spotkanie" },
            new Type() {Name = nameof(Phone), PolishName = "Telefon" },
            new Type() {Name = nameof(Duty), PolishName = "Obowiązek domowy" },
            new Type() {Name = nameof(Homework), PolishName = "Praca domowa" },
        };

        public static List<Activity> ActivitiesList { get => activitiesList; set => activitiesList = value; }
        public static List<Type> TypesOfActivities { get => typesOfActivities; set => typesOfActivities = value; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
