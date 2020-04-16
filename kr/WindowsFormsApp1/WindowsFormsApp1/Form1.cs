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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "admin";
            string password = "password";
          
            if ((login == this.textBox1.Text) && (password == this.maskedTextBox1.Text))
            {

                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
                
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
    }
    }
