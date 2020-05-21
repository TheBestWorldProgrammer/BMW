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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
            
        }
        public void Func(TextBox textBox1, TextBox textBox4, TextBox textBox5, TextBox textBox3, TextBox textBox2)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox4.Text;
            label3.Text = textBox5.Text;
            label4.Text = textBox3.Text;
            label5.Text = textBox2.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Func1(label1,label2,label3,label4,label5);
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(label1.Text,  label2.Text,  label3.Text,  label4.Text, label5.Text);
            f3.BackgroundImage = this.BackgroundImage;
            f3.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
