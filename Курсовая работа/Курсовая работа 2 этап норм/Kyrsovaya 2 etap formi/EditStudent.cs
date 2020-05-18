using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            var groups_for_list = (from g in db.parents select g.surname_parent).Distinct();
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
            var result = ((Main)Owner).db.students.SingleOrDefault(w => w.code_stud == item.code_stud);
            result.surname_stud = textBox2.Text.ToString();
            result.name_stud = textBox1.Text.ToString();
            result.lastname_stud = textBox3.Text.ToString();
            result.birthday_stud = dateTimePicker1.Value.ToUniversalTime();
            var query = (from g in db.parents where g.surname_parent == comboBox1.SelectedItem.ToString() select g.code_parent).ToList();
            result.code_parent = query[0];
            ((Main)Owner).studentsheet = ((Main)Owner).db.students.OrderBy(o => o.code_stud).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
