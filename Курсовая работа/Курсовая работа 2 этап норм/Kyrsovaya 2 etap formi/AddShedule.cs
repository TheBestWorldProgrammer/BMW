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
            var groups_for_list = (from g in db.students orderby g.code_stud select g.surname_stud).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
            var groups_for_list1 = (from g in db.lectors orderby g.code_lector select g.surname_lector).Distinct();
            foreach (string it in groups_for_list1)
                comboBox2.Items.Add(it);
            var groups_for_list2 = (from g in db.subjects orderby g.code_subject select g.name_subj).Distinct();
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
            try
            {
                Add add = new Add();
                add.AddShd(dateTimePicker1,comboBox1,comboBox2,comboBox3,comboBox4);
                this.Close();
            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
    }
}
