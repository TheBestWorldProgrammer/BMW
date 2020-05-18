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
    public partial class AddShedule : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddShedule()
        {
            InitializeComponent();
            var groups_for_list = (from g in db.students select g.surname_stud).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
            var groups_for_list1 = (from g in db.lectors select g.surname_lector).Distinct();
            foreach (string it in groups_for_list1)
                comboBox2.Items.Add(it);
            var groups_for_list2 = (from g in db.subjects select g.name_subj).Distinct();
            foreach (string it in groups_for_list2)
                comboBox3.Items.Add(it);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f6 = new AddSubject();
            f6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            var groups_for_list = (from g in db.subjects select g.name_subj).Distinct();
            foreach (string it in groups_for_list)
                comboBox3.Items.Add(it);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var query = (from g in db.students where g.surname_stud == comboBox1.SelectedItem.ToString() select g.code_stud).ToList();
            var query1 = (from g in db.lectors where g.surname_lector == comboBox2.SelectedItem.ToString() select g.code_lector).ToList();
            var query2 = (from g in db.subjects where g.name_subj == comboBox3.SelectedItem.ToString() select g.code_subject).ToList();
            int number_of_shedule = db.shedule.Max(n => n.code_shedule) + 1;
            shedule new_shedule = new shedule { code_shedule=number_of_shedule,code_stud=query[0],code_subject=query2[0],code_lector=query1[0],date_classes=dateTimePicker1.Value,time_classes=comboBox4.SelectedItem.ToString()};
            ((Main)Owner).db.shedule.Add(new_shedule);
            ((Main)Owner).sheduleshhet = ((Main)Owner).db.shedule.OrderBy(o => o.code_shedule).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();
        }
    }
}
