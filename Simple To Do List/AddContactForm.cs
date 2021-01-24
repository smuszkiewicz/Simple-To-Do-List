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
        private int t;
        public AddContactForm(int t)
        {
            this.t = t;
            InitializeComponent();
            if (t == 1)
            {
                Text = "Dodaj kontakt";
            }
            else if (t == 2)
            {
                Text = "Dodaj przedmiot";
                label1.Text = "Nazwa:";
                label2.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            else if (t == 3)
            {
                Text = "Dodaj obowiązek domowy";
                label1.Text = "Nazwa:";
                label2.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    try
                    {
                        Contact.AddContact(textBox1.Text, textBox2.Text, textBox3.Text);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        Error errorBox = new Error(exception.Message);
                        errorBox.Show();
                    }
                }
            }
            else if (t == 2)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    try
                    {
                        Homework.AddSubject(textBox1.Text);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        Error errorBox = new Error(exception.Message);
                        errorBox.Show();
                    }
                }
            }
            else if (t == 3)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    try
                    {
                        Duty.AddDutyType(textBox1.Text);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        Error errorBox = new Error(exception.Message);
                        errorBox.Show();
                    }
                }
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
