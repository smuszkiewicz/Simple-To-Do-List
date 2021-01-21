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
            
            if (comboBox1.SelectedItem.ToString() == "Phone")
            {
                label3.Text = "Do kogo?";
                label3.Visible = true;
                
            }
        }
    }
}
