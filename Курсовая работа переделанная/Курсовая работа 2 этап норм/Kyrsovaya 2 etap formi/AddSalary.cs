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
    public partial class AddSalary : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddSalary()
        {
            InitializeComponent();
            var groups_for_list = (from g in  db.lectors orderby g.code_lector select g.surname_lector).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Add add = new Add();
                add.AddSal(comboBox1,comboBox2,numericUpDown1,numericUpDown2,numericUpDown3);
                this.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

       
    }
}
