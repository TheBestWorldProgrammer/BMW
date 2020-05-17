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
    public partial class EditTeacher : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        lectors item;
        public EditTeacher(lectors lec)
        {
            item = lec;
            InitializeComponent();         
            textBox2.Text = item.name_lector.ToString();
            textBox1.Text = item.surname_lector.ToString();
            textBox3.Text = item.lastname_lector.ToString();
            dateTimePicker1.Value = item.birthday_lector;
            textBox5.Text = item.post.ToString();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Main)Owner).db.lectors.SingleOrDefault(w => w.code_lector == item.code_lector);
            result.surname_lector = textBox1.Text.ToString();
            result.name_lector = textBox2.Text.ToString();
            result.lastname_lector = textBox3.Text.ToString();
            result.birthday_lector = dateTimePicker1.Value;       
            result.post = textBox5.Text.ToString();
            ((Main)Owner).lectorsheet = ((Main)Owner).db.lectors.OrderBy(o => o.code_lector).ToList();
            ((Main)Owner).db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
