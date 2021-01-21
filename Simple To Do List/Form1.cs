using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Activity.ActivitiesList = SaveLoad.Load<Activity>("activites.dat");
            Contact.ContactList = SaveLoad.Load<Contact>("contacts.dat");
            Homework.Subjects = SaveLoad.Load<string>("subjects.dat");
            listBox1.DataSource = Activity.ActivitiesList;
        }
    }
}
