using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class phone : activity
    {
        private int twho;
        private string topic;

        public phone(DateTime dateTime, int twho, string topic)
        {
            this.dateTime = dateTime;
            this.twho = twho;
            this.topic = topic;
        }
    }
}
