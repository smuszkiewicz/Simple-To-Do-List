using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Simple_To_Do_List
{
    [Serializable]
    class Contact
    {
        private static BindingList<Contact> contactList = new BindingList<Contact>();
        private string fName;
        private string sName;
        private string number;
        

        private Contact(string fName, string sName, string number)
        {
            this.fName = fName;
            this.sName = sName;
            this.number = number;
        }

        internal static BindingList<Contact> ContactList { get => contactList; set => contactList = value; }

        public static void AddContact(string fName, string sName, string number)
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

        public override string ToString()
        {
            return fName + " " + sName + "(" + number + ")";
        }
        public static void RemoveContact(int i)
        {
            try
            {
                contactList.RemoveAt(i);
                SaveLoad.Save("contacts.dat", contactList);
            }
            catch
            {
                throw new Exception("Nie udało się usunąć :<");
            }
        }

    }
}
