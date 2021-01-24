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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    Contact.AddContact(textBox1.Text, textBox2.Text, textBox3.Text);
                    ContactForm contactForm = new ContactForm();
                    contactForm.ListBox1Refresh();
                    this.Close();
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
