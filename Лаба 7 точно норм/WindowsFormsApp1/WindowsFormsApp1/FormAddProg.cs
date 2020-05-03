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
    public partial class FormAddProg : Form
    {
        public demoEntities db = new demoEntities();       
        public FormAddProg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime((int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown1.Value);
            progress prog = new progress
            {
                code_stud = 1,
                code_subject = 1,
                code_lector = 1,
                estimate = (int)numericUpDown4.Value,
                date_exam = dt

            };
            db.progress.Add(prog);
            db.SaveChanges();
            this.Close();
        }

        private void FormAddProg_Load(object sender, EventArgs e)
        {

        }
    }
}
