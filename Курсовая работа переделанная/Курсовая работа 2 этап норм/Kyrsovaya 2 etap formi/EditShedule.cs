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
    public partial class EditShedule : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        shedule item;
        public EditShedule(shedule shd)
        {
            InitializeComponent();
            item = shd;
            var groups_for_list = (from g in db.students orderby g.code_stud select g.surname_stud).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
            var groups_for_list1 = (from g in db.lectors orderby g.code_lector select g.surname_lector).Distinct();
            foreach (string it in groups_for_list1)
                comboBox2.Items.Add(it);
            var groups_for_list2 = (from g in db.subjects orderby g.code_subject select g.name_subj).Distinct();
            foreach (string it in groups_for_list2)
                comboBox3.Items.Add(it);
            var query = (from g in db.students where g.code_stud == item.code_stud select g.surname_stud).ToList();
            comboBox1.SelectedItem = query[0];
            var query1 = (from g in db.lectors where g.code_lector == item.code_lector select g.surname_lector).ToList();
            comboBox2.SelectedItem = query1[0];
            var query2 = (from g in db.subjects where g.code_subject == item.code_subject select g.name_subj).ToList();
            comboBox3.SelectedItem = query2[0];
            var query3 = (from g in db.shedule where g.code_shedule == item.code_shedule select g.time_classes).ToList();
            comboBox4.SelectedItem = query3[0];
            dateTimePicker1.Value = item.date_classes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Edit edit = new Edit();
                edit.EditShd(dateTimePicker1,comboBox1,comboBox2,comboBox3,comboBox4,item);
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
    }
}
