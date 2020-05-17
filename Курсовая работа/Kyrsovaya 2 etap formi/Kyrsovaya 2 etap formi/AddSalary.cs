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
    public partial class AddSalary : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddSalary()
        {
            InitializeComponent();
            var groups_for_list = (from g in db.lectors select g.surname_lector).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from g in db.lectors where g.surname_lector == comboBox1.SelectedItem.ToString() select g.code_lector).ToList();
            int number_of_salary = db.salary.Max(n => n.code_salary) + 1;
            salary new_salary = new salary { code_salary = number_of_salary,code_lector=query[0] ,experience = Convert.ToInt32(numericUpDown2.Value), work_hour = Convert.ToInt32(numericUpDown3.Value), summ = Convert.ToInt32(numericUpDown1.Value),mounth=textBox3.Text };
            ((Main)Owner).db.salary.Add(new_salary);
            ((Main)Owner).salarysheet = ((Main)Owner).db.salary.OrderBy(o => o.code_salary).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();
        }
    }
}
