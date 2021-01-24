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
    public partial class ContactForm : Form
    {
        private int t;
        public ContactForm(int t)
        {
            InitializeComponent();
            if (t == 1)
            {
                listBox1.DataSource = Contact.ContactList;
                Text = "Kontakty";
                this.t = t;
            }
            else if (t == 2)
            {
                listBox1.DataSource = Homework.Subjects;
                Text = "Przedmioty";
                this.t = t;
            }
            else if (t == 3)
            {
                listBox1.DataSource = Duty.DutiesTypes;
                Text = "Obowiązki domowe";
                this.t = t;
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                try
                {
                    Contact.RemoveContact(listBox1.SelectedIndex);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
            else if (t == 2)
            {
                try
                {
                    Homework.RemoveSubject(listBox1.SelectedIndex);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
            else if (t == 3)
            {
                try
                {
                    Duty.RemoveDutyType(listBox1.SelectedIndex);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm(t);
            addContactForm.Show();
        }
    }
}
