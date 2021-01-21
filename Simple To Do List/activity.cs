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
        public static List<Activity> ActivitiesList = new List<Activity>();
    }
}
