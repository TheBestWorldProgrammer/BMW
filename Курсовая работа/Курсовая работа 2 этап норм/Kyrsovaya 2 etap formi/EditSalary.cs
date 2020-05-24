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
    public partial class EditSalary : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        salary item;
        public EditSalary( salary sal)
        {        
            item = sal;
            InitializeComponent();
            var groups_for_list = (from g in db.lectors orderby g.code_lector select g.surname_lector).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
            numericUpDown2.Value = Convert.ToInt32(item.experience);
            numericUpDown3.Value = Convert.ToInt32(item.work_hour);
            numericUpDown1.Value = Convert.ToInt32(item.summ);
            var query1 = (from g in db.salary where g.code_salary == item.code_salary select g.mounth).ToList();
            comboBox2.SelectedItem = query1[0];
            var query = (from g in db.lectors where g.code_lector == item.code_lector select g.surname_lector).ToList();
            comboBox1.SelectedItem = query[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Edit edit = new Edit();
                edit.EditSal(numericUpDown1,numericUpDown2,numericUpDown3,comboBox1,  comboBox2,  item);
                this.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

       
    }
}
