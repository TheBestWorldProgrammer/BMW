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
    public partial class EditEstimate : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        estimate item;
        public EditEstimate( estimate est)
        {
            item = est;
            InitializeComponent();
            var groups_for_list = (from g in db.shedule select g.code_shedule).Distinct();
            foreach (int it in groups_for_list)
                comboBox1.Items.Add(it);
            numericUpDown1.Value = Convert.ToInt32(item.name_est);
            var query = (from g in db.shedule where g.code_shedule == item.code_shedule select g.code_shedule).ToList();
            comboBox1.SelectedItem = query[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Main)Owner).db.estimate.SingleOrDefault(w => w.code_shedule == item.code_shedule);
            result.name_est = numericUpDown1.Value.ToString();          
            var query = (from g in db.estimate where g.code_shedule.ToString() == comboBox1.SelectedItem.ToString() select g.code_est).ToList();
            result.code_est = query[0];
            ((Main)Owner).estimatesheet = ((Main)Owner).db.estimate.OrderBy(o => o.code_est).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();

        }
    }
}
