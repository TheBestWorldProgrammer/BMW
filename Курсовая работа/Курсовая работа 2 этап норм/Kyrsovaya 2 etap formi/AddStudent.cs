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

namespace Kyrsovaya_2_etap_formi
{
    public partial class AddStudent : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddStudent()
        {
            InitializeComponent();
           
            var groups_for_list = (from g in db.parents orderby g.code_parent select g.surname_parent).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.schoolDataSet2.parents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Add add = new Add();
                add.AddStud(dateTimePicker1,textBox1,textBox2,textBox3,comboBox1);
                this.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void button3_Click(object sender, EventArgs e)
        {
            Form f7 = new AddParent();
            f7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {          
            comboBox1.Items.Clear();
            var groups_for_list = (from g in db.parents select g.surname_parent).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
