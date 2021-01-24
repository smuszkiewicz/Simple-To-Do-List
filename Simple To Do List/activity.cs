﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.ComponentModel;

namespace Simple_To_Do_List
{
    [Serializable]
    abstract class Activity
    {
        protected DateTime dateTime;
        protected string note;
        private static BindingList<Activity> activitiesList = new BindingList<Activity>();
        private static BindingList<Type> typesOfActivities = new BindingList<Type>
        {
            new Type() {Name = nameof(Meeting), PolishName = "Spotkanie" },
            new Type() {Name = nameof(Phone), PolishName = "Telefon" },
            new Type() {Name = nameof(Duty), PolishName = "Obowiązek domowy" },
            new Type() {Name = nameof(Homework), PolishName = "Praca domowa" },
        };

        public static BindingList<Activity> ActivitiesList { get => activitiesList; set => activitiesList = value; }
        public static BindingList<Type> TypesOfActivities { get => typesOfActivities; set => typesOfActivities = value; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
        public static void RemoveActivity(int i)
        {
            try
            {
                activitiesList.RemoveAt(i);
                SaveLoad.Save("activites.dat", activitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się usunąć :<");
            }
        }
    }
}
