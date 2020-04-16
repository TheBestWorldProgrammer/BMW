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
    public partial class FormEditStud : Form
    {
        public contEntities db = new contEntities();
        s_students item;
        public FormEditStud(s_students stud)
        {
            item = stud;
            InitializeComponent();
            var groups_for_list = (from g in db.s_in_group select g.group_num).Distinct().ToString(); 
            textBox1.Text = item.surname.ToString();
            textBox2.Text = item.name.ToString();
            textBox3.Text = item.middlename.ToString();
            var query = (from g in db.s_in_group where g.id_group == item.id_group select g.group_num).ToList();
            comboBox1.SelectedItem = query[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
