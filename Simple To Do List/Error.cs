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
    public partial class Error : Form
    {
        private string message;
        public Error(string message)
        {
            this.message = message;
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
