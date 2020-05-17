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
    public partial class AddTeacher : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddTeacher()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {       
            int number_of_lector = db.lectors.Max(n => n.code_lector) + 1;
            lectors new_lector = new lectors {  code_lector= number_of_lector, surname_lector = textBox1.Text, name_lector = textBox2.Text, lastname_lector = textBox3.Text, birthday_lector = Convert.ToDateTime(dateTimePicker1.Value), post=textBox5.Text };
            ((Main)Owner).db.lectors.Add(new_lector);
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
