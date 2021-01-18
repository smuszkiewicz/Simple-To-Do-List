using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class homework : activity
    {
        static private List<string> subjects = new List<string>();
        private string subject;

        public homework(DateTime dateTime, int type)
        {
            this.dateTime = dateTime;
            this.subject = subjects[type];
        }

    }
}
