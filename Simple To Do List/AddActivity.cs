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
        public AddActivity(int i)
        {
            InitializeComponent();
            comboBox1.DataSource = Activity.TypesOfActivities;
            comboBox1.DisplayMember = "PolishName";
            comboBox1.ValueMember = "Name";
            button2.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            Text = "Zadanie";
            if (Activity.ActivitiesList[i].GetType() == typeof(Meeting))
            {
                var meeting = Activity.ActivitiesList[i] as Meeting;
                comboBox1.SelectedIndex = 0;
                label3.Text = "Z kim?";
                comboBox2.DataSource = Contact.ContactList;
                comboBox2.SelectedItem = meeting.Wwho;
                textBox1.Text = meeting.Note;
            }
            else if (Activity.ActivitiesList[i].GetType() == typeof(Phone))
            {
                var phone = Activity.ActivitiesList[i] as Phone;
                comboBox1.SelectedIndex = 1;
                label3.Text = "Do kogo?";
                comboBox2.DataSource = Contact.ContactList;
                comboBox2.SelectedItem = phone.Twho;
                textBox1.Text = phone.Note;
            }
            else if (Activity.ActivitiesList[i].GetType() == typeof(Duty))
            {
                var duty = Activity.ActivitiesList[i] as Duty;
                comboBox1.SelectedIndex = 2;
                label3.Text = "Jaki?";
                comboBox2.DataSource = Duty.DutiesTypes;
                textBox1.Text = duty.Note;
            }
            else if (Activity.ActivitiesList[i].GetType() == typeof(Homework))
            {
                var homework = Activity.ActivitiesList[i] as Homework;
                comboBox1.SelectedIndex = 3;
                label3.Text = "Z jakiego przedmiotu?";
                comboBox2.DataSource = Homework.Subjects;
                textBox1.Text = homework.Note;
            }
            dateTimePicker1.Value = Activity.ActivitiesList[i].DateTime;
            
        }
        public AddActivity()
        {
            InitializeComponent();
            comboBox1.DataSource = Activity.TypesOfActivities;
            comboBox1.DisplayMember = "PolishName";
            comboBox1.ValueMember = "Name";
            comboBox2.DataSource = Contact.ContactList;
        }


        private void AddActivity_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Telefon")
            {
                label3.Text = "Do kogo?";
                comboBox2.DataSource = Contact.ContactList;
            }
            else if (comboBox1.Text == "Spotkanie")
            {
                label3.Text = "Z kim?";
                comboBox2.DataSource = Contact.ContactList;
            }
            else if (comboBox1.Text == "Praca domowa")
            {
                label3.Text = "Z jakiego przedmiotu?";
                comboBox2.DataSource = Homework.Subjects;
            }
            else if (comboBox1.Text == "Obowiązek domowy")
            {
                label3.Text = "Jaki?";
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
                }
                catch (Exception exception)
                {
                    Error errorBox = new Error(exception.Message);
                    errorBox.Show();
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
