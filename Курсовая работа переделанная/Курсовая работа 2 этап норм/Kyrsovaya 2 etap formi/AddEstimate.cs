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
    public partial class AddEstimate : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();

        public AddEstimate()
        {
          
            InitializeComponent();
            var groups_for_list = (from g in db.shedule orderby g.code_shedule select g.code_shedule).Distinct();
            foreach (int it in groups_for_list)
                comboBox1.Items.Add(it);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {             
                Add add = new Add();
                add.AddEst(numericUpDown1,comboBox1);
                this.Close();
            }
            catch(Exception z)
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
