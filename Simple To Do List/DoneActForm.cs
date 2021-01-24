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
    public partial class DoneActForm : Form
    {
        public DoneActForm()
        {
            InitializeComponent();
        }

        private void DoneActForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Activity.DoneActivities;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
