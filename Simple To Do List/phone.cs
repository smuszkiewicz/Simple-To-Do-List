using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Simple_To_Do_List
{
    [Serializable]
    class Phone : Activity
    {
        private Contact twho;

        private Phone(DateTime dateTime, int twho, string note)
        {
            this.dateTime = dateTime;
            this.twho = Contact.ContactList[twho];
            this.note = note;
        }

        public Contact Twho { get => twho; set => twho = value; }

        public static void AddPhone(DateTime dateTime, int twho, string note)
        {
            try
            {
                Activity.ActivitiesList.Add(new Phone(dateTime, twho, note));
                Activity.ActivitiesList = new BindingList<Activity>(Activity.ActivitiesList.OrderBy(x => x.DateTime).ToList());
                SaveLoad.Save("activities.dat", Activity.ActivitiesList);
            }
            catch
            {
                throw new Exception("Nie udało się dodać :<");
            }
        }
        public override string ToString()
        {
            return dateTime.ToString("dd/MM/yyyy") + " Telefon do " + twho.ToString();
        }

    }
}
