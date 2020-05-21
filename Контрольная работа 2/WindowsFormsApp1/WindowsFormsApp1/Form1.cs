using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }
        public void Func1(Label label1, Label label2, Label label3, Label label4, Label label5)
        {
            textBox1.Text = label1.Text;
            textBox4.Text = label2.Text;
            textBox5.Text = label3.Text;
            textBox3.Text = label4.Text;
            textBox2.Text = label5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.BackgroundImage = pictureBox1.BackgroundImage;
            f2.Func(textBox1, textBox4, textBox5, textBox3,textBox2);
            f2.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[2];
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

      
    }
}
