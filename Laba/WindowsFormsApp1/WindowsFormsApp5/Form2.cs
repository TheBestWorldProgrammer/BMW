using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            Program.f2 = this;
            InitializeComponent();
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f1.WindowState = FormWindowState.Normal;
            this.Hide();
        }
    }
}
