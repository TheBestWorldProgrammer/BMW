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
        public List<students> studentsheet;
        public List<lectors> lectorsheet;
        public List<shedule> sheduleshhet;
        public List<salary> salarysheet;
        public List<estimate> estimatesheet;
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public Main()
        {
            InitializeComponent();
            /*studentsheet = (from stud in db.students select stud).ToList();
            var query = (from stud in studentsheet                         
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname_stud, stud.name_stud,stud.lastname_stud, stud.birthday_stud,stud.code_parent }).ToList();
            dataGridView5.DataSource = query;
            dataGridView5.ReadOnly = true;*/
            estimatesheet=(from est in db.estimate select est).ToList();
            var query = (from est in estimatesheet
                         join g in db.shedule on est.code_shedule equals g.code_shedule
                         join b in db.subjects on g.code_subject equals b.code_subject
                         orderby est.code_est
                         select new { est.code_est,est.name_est, b.name_subj }).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Оценка";
            dataGridView1.Columns[2].HeaderText = "Код расписания";

            var query1 = (from sal in db.salary
                         join g in db.lectors on sal.code_lector equals g.code_lector                    
                         orderby sal.code_salary
                         select new { sal.code_salary, g.surname_lector, sal.experience,sal.work_hour,sal.summ,sal.mounth}).ToList();
            dataGridView2.DataSource = query1;
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Учитель";
            dataGridView2.Columns[2].HeaderText = "Стаж";
            dataGridView2.Columns[3].HeaderText = "Рабочие часы";
            dataGridView2.Columns[4].HeaderText = "Сумма";
            dataGridView2.Columns[5].HeaderText = "Месяц";

            var query2 = (from prog in db.shedule
                          join g in db.lectors on prog.code_lector equals g.code_lector
                          join b in db.students on prog.code_stud equals b.code_stud
                          join c in db.subjects on prog.code_subject equals c. code_subject
                          orderby prog.code_shedule
                          select new { prog.code_shedule,b.surname_stud, c.name_subj, g.surname_lector,prog.date_classes }).ToList();
            dataGridView3.DataSource = query2;
            dataGridView3.ReadOnly = true;
            dataGridView3.Columns[0].HeaderText = "Код расписания";
            dataGridView3.Columns[1].HeaderText = "Ученик";
            dataGridView3.Columns[2].HeaderText = "Предмет";
            dataGridView3.Columns[3].HeaderText = "Учитель";
            dataGridView3.Columns[4].HeaderText = "Дата";
           


        }
        #region Func
        public string TxtBox
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public void Tbpg(int Tbpg)
        {
           
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
                        button7.Enabled = false;
                        button9.Enabled = false;
                        button8.Enabled = false;
                        button10.Enabled = false;
                        button11.Enabled = false;
                        button12.Enabled = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
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
        #endregion
       
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.schoolDataSet2.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.lectors". При необходимости она может быть перемещена или удалена.
            this.lectorsTableAdapter.Fill(this.schoolDataSet2.lectors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.shedule". При необходимости она может быть перемещена или удалена.
            this.sheduleTableAdapter.Fill(this.schoolDataSet2.shedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.schoolDataSet2.subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.salary". При необходимости она может быть перемещена или удалена.
            this.salaryTableAdapter.Fill(this.schoolDataSet2.salary);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.estimate". При необходимости она может быть перемещена или удалена.
            this.estimateTableAdapter.Fill(this.schoolDataSet2.estimate);         

        }
        #region BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new AddStudent();
            f3.Owner = this;
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<students> query = (from stud in db.students select stud).ToList();
            if (dataGridView5.SelectedCells.Count == 1)
            { 
                    students item = query.First(w => w.code_stud.ToString() == dataGridView5.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EditStudent editSt = new EditStudent(item);
                    editSt.Owner = this;
                    editSt.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = (from stud in db.students select new { stud.code_stud, stud.surname_stud, stud.name_stud, stud.lastname_stud, stud.birthday_stud, stud.code_parent }).ToList();
            dataGridView5.DataSource = query;
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            Form f4 = new AddTeacher();
            f4.Owner = this;
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<lectors> query = (from lec in db.lectors select lec).ToList();
            if (dataGridView4.SelectedCells.Count == 1)
            {
                lectors item = query.First(w => w.code_lector.ToString() == dataGridView4.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                EditTeacher editSt = new EditTeacher(item);
                editSt.Owner = this;
                editSt.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var query = (from lec in db.lectors select new { lec.code_lector, lec.surname_lector, lec.name_lector, lec.lastname_lector, lec.birthday_lector, lec.post }).ToList();
            dataGridView4.DataSource = query;
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            Form f5 = new AddShedule();
            f5.Owner = this;
            f5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<shedule> query = (from prog in db.shedule select prog).ToList();
            if (dataGridView3.SelectedCells.Count == 1)
            {
                shedule item = query.First(w => w.code_shedule.ToString() == dataGridView3.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                EditShedule editSt = new EditShedule(item);
                editSt.Owner = this;
                editSt.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var query2 = (from prog in db.shedule
                          join g in db.lectors on prog.code_lector equals g.code_lector
                          join b in db.students on prog.code_stud equals b.code_stud
                          join c in db.subjects on prog.code_subject equals c.code_subject
                          orderby prog.code_shedule
                          select new { prog.code_shedule, b.surname_stud, c.name_subj, g.surname_lector, prog.date_classes }).ToList();
            dataGridView3.DataSource = query2;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form f6 = new AddSalary();
            f6.Owner = this;
            f6.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<salary> query = (from sal in db.salary select sal).ToList();
            if (dataGridView2.SelectedCells.Count == 1)
            {
                salary item = query.First(w => w.code_salary.ToString() == dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                EditSalary editSt = new EditSalary(item);
                editSt.Owner = this;
                editSt.Show();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            var query = (from sal in db.salary
                         join g in db.lectors on sal.code_lector equals g.code_lector
                         select new {sal.code_salary, g.surname_lector, sal.experience,sal.work_hour,sal.summ,sal.mounth}).ToList();
            dataGridView2.DataSource = query;
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            AddEstimate f= new AddEstimate();
            f.Owner = this;
            f.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<estimate> query = (from est in estimatesheet select est).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                estimate item = query.First(w => w.code_est.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                EditEstimate editSt = new EditEstimate(item);
                editSt.Owner = this;
                editSt.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var query = (from est in db.estimate select new { est.code_est, est.name_est, est.code_shedule }).ToList();
            dataGridView1.DataSource = query;
        }
        #endregion
      
    }
}
