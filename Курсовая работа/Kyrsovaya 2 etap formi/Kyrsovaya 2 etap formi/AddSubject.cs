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
    public partial class AddSubject : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddSubject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_of_sublect = db.subjects.Max(n => n.code_subject) + 1;
            subjects new_subject = new subjects { code_subject = number_of_sublect, name_subj=textBox2.Text };
            db.subjects.Add(new_subject);
            db.SaveChanges();
            this.Close();
        }
    }
}
