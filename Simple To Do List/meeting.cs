using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class meeting : activity
    {
        private int wwho;
        private string place;

        public meeting(DateTime dateTime, int wwho, string place)
        {
            this.dateTime = dateTime;
            this.wwho = wwho;
            this.place = place;
        }
    }
}
