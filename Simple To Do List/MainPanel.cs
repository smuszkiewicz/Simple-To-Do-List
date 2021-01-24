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
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Activity.ActivitiesList = SaveLoad.Load<Activity>("activities.dat");
            Contact.ContactList = SaveLoad.Load<Contact>("contacts.dat");
            Homework.Subjects = SaveLoad.Load<string>("subjects.dat");
            Duty.DutiesTypes = SaveLoad.Load<string>("dutiesTypes.dat");
            Activity.DoneActivities = SaveLoad.Load<Activity>("doneActivities.dat");
            listBox1.DataSource = Activity.ActivitiesList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Activity.RemoveActivity(listBox1.SelectedIndex);
            }
            catch (Exception exception)
            {
                Error errorBox = new Error(exception.Message);
                errorBox.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(1);
            contactForm.Show();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddActivity addActivity = new AddActivity(listBox1.SelectedIndex);
            addActivity.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(2);
            contactForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(3);
            contactForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Activity.MoveToDone(listBox1.SelectedIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DoneActForm doneActForm = new DoneActForm();
            doneActForm.Show();
        }
    }
}
