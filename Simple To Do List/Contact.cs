using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    class Contact
    {
        public static List<string> contactList = new List<string>();
        private string fName;
        private string sName;
        private string number;

        public Contact(string fName, string sName, string number)
        {
            this.fName = fName;
            this.sName = sName;
            this.number = number;
        }
    }
}
