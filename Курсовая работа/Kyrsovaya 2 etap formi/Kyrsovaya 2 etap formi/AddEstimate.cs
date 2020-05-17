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
            var groups_for_list = (from g in db.shedule select g.code_shedule).Distinct();
            foreach (int it in groups_for_list)
                comboBox1.Items.Add(it);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_of_estimate=1;
            var query = (from g in db.shedule where g.code_shedule == (int)comboBox1.SelectedItem select g.code_shedule).ToList();  
            // ТАк как не добавлены оценки метод max нельзя использовать поэтому я хотел снасла внести изменения а потом уже все сделать но из-за ошибки сохранения ничего не могу сделать
           // number_of_estimate = db.estimate.Max(n => n.code_est) + 1;
            estimate new_estimate = new estimate { code_est=number_of_estimate, name_est=numericUpDown1.Value.ToString(),code_shedule=5/*query[0]*/  };
            ((Main)Owner).db.estimate.Add(new_estimate);
            ((Main)Owner).estimatesheet = ((Main)Owner).db.estimate.OrderBy(o => o.code_est).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
