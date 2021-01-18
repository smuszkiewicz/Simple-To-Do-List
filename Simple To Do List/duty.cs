using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class duty : activity
    {
        static private List<string> duties = new List<string>();
        private string type;

        public duty(DateTime dateTime, int type)
        {
            this.dateTime = dateTime;
            this.type = duties[type];
        }
    }
}
