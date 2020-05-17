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
            var groups_for_list = (from g in db.lectors select g.surname_lector).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
            numericUpDown2.Value = Convert.ToInt32(item.experience);
            numericUpDown3.Value = Convert.ToInt32(item.work_hour);
            numericUpDown1.Value = Convert.ToInt32(item.summ);
            textBox3.Text = item.mounth.ToString();
            var query = (from g in db.lectors where g.code_lector == item.code_lector select g.surname_lector).ToList();
            comboBox1.SelectedItem = query[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Main)Owner).db.salary.SingleOrDefault(w => w.code_salary == item.code_salary);
            result.experience = Convert.ToInt32(numericUpDown2.Value);
            result.work_hour = Convert.ToInt32(numericUpDown3.Value);
            result.summ = Convert.ToInt32(numericUpDown1.Value);
            result.mounth = textBox3.Text.ToString();
            var query = (from g in db.lectors where g.surname_lector == comboBox1.SelectedItem.ToString() select g.code_lector).ToList();
            result.code_lector = query[0];
            ((Main)Owner).salarysheet = ((Main)Owner).db.salary.OrderBy(o => o.code_salary).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();
        }
    }
}
