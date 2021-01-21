﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Meeting : Activity
    {
        private string wwho;
        private string place;

        private Meeting(DateTime dateTime, int wwho, string place)
        {
            this.dateTime = dateTime;
            this.wwho = Contact.ContactList[wwho].ToString();
            this.place = place;
        }

        public static void AddMeeting(DateTime dateTime, int wwho, string place)
        {
            Activity.ActivitiesList.Add(new Meeting(dateTime, wwho, place));
            SaveLoad.Save("activites.dat", Activity.ActivitiesList);
        }
    }
}
