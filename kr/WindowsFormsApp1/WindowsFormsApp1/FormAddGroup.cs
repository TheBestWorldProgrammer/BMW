using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddGroup : Form
    {
        public contEntities db = new contEntities();
        public FormAddGroup()
        {
            InitializeComponent();
            var groups_for_list = (from g in db.s_in_group select g.group_num).Distinct();
          
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number_of_group = db.s_in_group.Max(n => n.id_group) + 1;
            s_in_group new_group = new s_in_group { id_group = number_of_group, group_num = Convert.ToInt32(textBox1.Text), kurs_num = Convert.ToInt32(textBox2.Text)};
            db.s_in_group.Add(new_group);
            db.SaveChanges();
            this.Close();
        }

    }
}
