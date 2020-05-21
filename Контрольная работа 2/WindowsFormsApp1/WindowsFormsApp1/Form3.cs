using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3(string Label1, string Label2, string Label3, string Label4, string Label5)
        {
            InitializeComponent();
            label1.Text = Label1;
            label2.Text = Label2;
            label3.Text = Label3;
            label4.Text = Label4;
            label5.Text = Label5;
        }
    }
}
