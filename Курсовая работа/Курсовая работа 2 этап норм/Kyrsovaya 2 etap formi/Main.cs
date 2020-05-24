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
    public partial class Main : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public Main()
        {
            try
            {
                InitializeComponent();
                Show ShowEst = new Show();
                ShowEst.ShowEst(dataGridView1);


                Show ShowSal = new Show();
                ShowSal.ShowSalary(dataGridView2);


                Show ShowShd = new Show();
                ShowShd.ShowShedule(dataGridView3);
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }


        }
        #region Func
        public string TxtBox
        {         
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public void Tbpg(int Tbpg)
        {
            try {
                switch (Tbpg)
                {
                    case 0:
                        tabControl1.TabPages[0].Parent = null;
                        tabControl1.TabPages[3].Parent = null;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button9.Enabled = false;
                        button8.Enabled = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        break;
                    case 1:
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button10.Enabled = false;
                        button11.Enabled = false;
                        button12.Enabled = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button10.Visible = false;
                        button11.Visible = false;
                        button12.Visible = false;
                        break;
                    case 2:
                        tabControl1.TabPages[3].Parent = null;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button9.Enabled = false;
                        button8.Enabled = false;
                        button13.Enabled = false;
                        button14.Enabled = false;
                        button15.Enabled = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button13.Visible = false;
                        button14.Visible = false;
                        button15.Visible = false;
                        break;
                    case 3:
                        tabControl1.TabPages[3].Parent = null;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button9.Enabled = false;
                        button8.Enabled = false;
                        button13.Enabled = false;
                        button14.Enabled = false;
                        button15.Enabled = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button13.Visible = false;
                        button14.Visible = false;
                        button15.Visible = false;
                        break;
                    case 4:
                        textBox1.ReadOnly = false;
                        break;
                }
                }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }

        }
        #endregion
       
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.students". При необходимости она может быть перемещена или удалена.
                this.studentsTableAdapter.Fill(this.schoolDataSet2.students);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.lectors". При необходимости она может быть перемещена или удалена.
                this.lectorsTableAdapter.Fill(this.schoolDataSet2.lectors);
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }

        }
        #region BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form f3 = new AddStudent();
                f3.ShowDialog();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<students> query = (from stud in db.students select stud).ToList();
                if (dataGridView5.SelectedCells.Count == 1)
                {
                    students item = query.First(w => w.code_stud.ToString() == dataGridView5.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EditStudent editSt = new EditStudent(item);
                    editSt.ShowDialog();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from stud in db.students orderby stud.code_stud select new { stud.code_stud, stud.surname_stud, stud.name_stud, stud.lastname_stud, stud.birthday_stud, stud.code_parent }).ToList();
                dataGridView5.DataSource = query;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form f4 = new AddTeacher();
                f4.ShowDialog();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<lectors> query = (from lec in db.lectors select lec).ToList();
                if (dataGridView4.SelectedCells.Count == 1)
                {
                    lectors item = query.First(w => w.code_lector.ToString() == dataGridView4.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EditTeacher editSt = new EditTeacher(item);
                    editSt.ShowDialog();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from lec in db.lectors orderby lec.code_lector select new { lec.code_lector, lec.surname_lector, lec.name_lector, lec.lastname_lector, lec.birthday_lector, lec.post }).ToList();
                dataGridView4.DataSource = query;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Form f5 = new AddShedule();
                f5.ShowDialog();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                List<shedule> query = (from prog in db.shedule select prog).ToList();
                if (dataGridView3.SelectedCells.Count == 1)
                {
                    shedule item = query.First(w => w.code_shedule.ToString() == dataGridView3.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EditShedule editSt = new EditShedule(item);
                    editSt.ShowDialog();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var query2 = (from prog in db.shedule
                              join g in db.lectors on prog.code_lector equals g.code_lector
                              join b in db.students on prog.code_stud equals b.code_stud
                              join c in db.subjects on prog.code_subject equals c.code_subject
                              orderby prog.code_shedule
                              select new { prog.code_shedule, b.surname_stud, c.name_subj, g.surname_lector, prog.date_classes, prog.time_classes }).ToList();
                dataGridView3.DataSource = query2;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Form f6 = new AddSalary();
                f6.ShowDialog();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                List<salary> query = (from sal in db.salary select sal).ToList();
                if (dataGridView2.SelectedCells.Count == 1)
                {
                    salary item = query.First(w => w.code_salary.ToString() == dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EditSalary editSt = new EditSalary(item);
                    editSt.ShowDialog();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from sal in db.salary
                             join g in db.lectors on sal.code_lector equals g.code_lector
                             orderby sal.code_salary
                             select new { sal.code_salary, g.surname_lector, sal.experience, sal.work_hour, sal.summ, sal.mounth }).ToList();
                dataGridView2.DataSource = query;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                AddEstimate f = new AddEstimate();
                f.ShowDialog();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                List<estimate> query = (from est in db.estimate select est).ToList();
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    estimate item = query.First(w => w.code_est.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EditEstimate editSt = new EditEstimate(item);
                    editSt.ShowDialog();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from est in db.estimate
                             join g in db.shedule on est.code_shedule equals g.code_shedule
                             join b in db.subjects on g.code_subject equals b.code_subject
                             join c in db.students on g.code_stud equals c.code_stud
                             orderby est.code_est
                             select new { est.code_est, g.code_shedule, est.name_est, b.name_subj, c.surname_stud }).ToList();
                dataGridView1.DataSource = query;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();

        }
    }
}
