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
    public partial class EditStudent : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        students item;
        public EditStudent(students stud)
        {
            item = stud;
            InitializeComponent();         
            var groups_for_list = (from g in db.parents orderby g.code_parent select g.surname_parent).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
            textBox1.Text = item.name_stud.ToString();
            textBox2.Text = item.surname_stud.ToString();
            textBox3.Text = item.lastname_stud.ToString();
            dateTimePicker1.Value = item.birthday_stud.ToUniversalTime();
            var query = (from g in db.parents where g.code_parent == item.code_parent select g.surname_parent).ToList();
            comboBox1.SelectedItem = query[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit edit = new Edit();
                edit.EditStud(dateTimePicker1,textBox1,textBox2,textBox3,comboBox1,item);
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
