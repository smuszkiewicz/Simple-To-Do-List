using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_To_Do_List
{
    [Serializable]
    class Contact
    {
        private static List<Contact> contactList = new List<Contact>();
        private string fName;
        private string sName;
        private string number;

        private Contact(string fName, string sName, string number)
        {
            this.fName = fName;
            this.sName = sName;
            this.number = number;
        }

        internal static List<Contact> ContactList { get => contactList; set => contactList = value; }

        public void AddContact(string fName, string sName, string number)
        {
            try
            {
                contactList.Add(new Contact(fName, sName, number));
                SaveLoad.Save("contacts.dat", contactList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }
    }
}
