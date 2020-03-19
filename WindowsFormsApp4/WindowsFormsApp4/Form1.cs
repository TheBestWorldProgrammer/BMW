using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string log, par;
        Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            par = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log1 = "admin";
            string par1 = "1234";
            if (log == log1 && par == par1)
            {
                form2.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Неверный логин или пароль");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            log = textBox1.Text;
        }
    }
}
