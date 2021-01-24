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
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
        }

        private void AddActivity_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Activity.TypesOfActivities;
            comboBox1.DisplayMember = "PolishName";
            comboBox1.ValueMember = "Name";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Telefon")
            {
                label3.Text = "Do kogo?";
                label3.Visible = true;
                comboBox2.Enabled = true;
                comboBox2.DataSource = Contact.ContactList;
            }
            else if (comboBox1.Text == "Spotkanie")
            {
                label3.Text = "Z kim?";
                label3.Visible = true;
                comboBox2.Enabled = true;
                comboBox2.DataSource = Contact.ContactList;
            }
            else if (comboBox1.Text == "Praca domowa")
            {
                label3.Text = "Z jakiego przedmiotu?";
                label3.Visible = true;
                comboBox2.Enabled = true;
                comboBox2.DataSource = Homework.Subjects;
            }
            else if (comboBox1.Text == "Obowiązek domowy")
            {
                label3.Text = "Jaki?";
                label3.Visible = true;
                comboBox2.Enabled = true;
                comboBox2.DataSource = Duty.DutiesTypes;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Telefon")
            {
                try
                {
                    Phone.AddPhone(dateTimePicker1.Value, comboBox2.SelectedIndex, textBox1.Text);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
            else if (comboBox1.Text == "Spotkanie")
            {
                try
                {
                    Meeting.AddMeeting(dateTimePicker1.Value, comboBox2.SelectedIndex, textBox1.Text);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
            else if (comboBox1.Text == "Praca domowa")
            {
                try
                {
                    Homework.AddHomework(dateTimePicker1.Value, comboBox2.SelectedIndex, textBox1.Text);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }
            else if (comboBox1.Text == "Obowiązek domowy")
            {
                try
                {
                    Duty.AddDuty(dateTimePicker1.Value, comboBox2.SelectedIndex, textBox1.Text);
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }

        }
    }
}
