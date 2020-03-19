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
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           pictureBox1.BackgroundImage= imageList1.Images[0];
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = pictureBox1.BackgroundImage;
            this.pictureBox1.Visible = false;
            this.groupBox1.Visible = false;
            timer1.Enabled=true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[2];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = pictureBox1.BackgroundImage;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
        }
    }
}
