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
    public partial class AddParent : Form
    {
        public AddParent()
        {
            InitializeComponent();
        }
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public List<parents> parentsheet;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_of_parent = db.parents.Max(n => n.code_parent) + 1;
            parents new_parent = new parents {code_parent = number_of_parent, surname_parent = textBox1.Text, name_parent = textBox2.Text, lastname_parent = textBox3.Text,adress=textBox4.Text };
            db.parents.Add(new_parent);
            db.SaveChanges();          
            this.Close();
        }
    }
}
