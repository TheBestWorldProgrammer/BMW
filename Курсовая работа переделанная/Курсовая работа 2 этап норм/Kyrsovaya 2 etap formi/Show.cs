using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya_2_etap_formi
{
    class Show
    {
        public Show() { }
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public void ShowEst(DataGridView dataGridView)
        {
            try
            {
                List<estimate> estimatesheet = (from est in db.estimate select est).ToList(); ;
                var query = (from est in estimatesheet
                             join g in db.shedule on est.code_shedule equals g.code_shedule
                             join b in db.subjects on g.code_subject equals b.code_subject
                             join c in db.students on g.code_stud equals c.code_stud
                             orderby est.code_est
                             select new { est.code_est, g.code_shedule, est.name_est, b.name_subj, c.surname_stud }).ToList();
                dataGridView.DataSource = query;
                dataGridView.ReadOnly = true;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].HeaderText = "Код расписания";
                dataGridView.Columns[2].HeaderText = "Оценка";
                dataGridView.Columns[3].HeaderText = "Предмет";
                dataGridView.Columns[4].HeaderText = "Ученик";
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
        public void ShowSalary(DataGridView dataGridView)
        {
            try
            {
                List<salary> salarysheet = (from sal in db.salary select sal).ToList();
                var query1 = (from sal in salarysheet
                              join g in db.lectors on sal.code_lector equals g.code_lector
                              orderby sal.code_salary
                              select new { sal.code_salary, g.surname_lector, sal.experience, sal.work_hour, sal.summ, sal.mounth }).ToList();
                dataGridView.DataSource = query1;
                dataGridView.ReadOnly = true;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].HeaderText = "Учитель";
                dataGridView.Columns[2].HeaderText = "Стаж";
                dataGridView.Columns[3].HeaderText = "Рабочие часы";
                dataGridView.Columns[4].HeaderText = "Сумма";
                dataGridView.Columns[5].HeaderText = "Месяц";
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
        public void ShowShedule(DataGridView dataGridView)
        {
            try
            {

                List<shedule> sheduleshhet = (from shd in db.shedule select shd).ToList();
                var query2 = (from prog in sheduleshhet
                              join g in db.lectors on prog.code_lector equals g.code_lector
                              join b in db.students on prog.code_stud equals b.code_stud
                              join c in db.subjects on prog.code_subject equals c.code_subject
                              orderby prog.code_shedule
                              select new { prog.code_shedule, b.surname_stud, c.name_subj, g.surname_lector, prog.date_classes, prog.time_classes }).ToList();
                dataGridView.DataSource = query2;
                dataGridView.ReadOnly = true;
                dataGridView.Columns[0].HeaderText = "Код расписания";
                dataGridView.Columns[1].HeaderText = "Ученик";
                dataGridView.Columns[2].HeaderText = "Предмет";
                dataGridView.Columns[3].HeaderText = "Учитель";
                dataGridView.Columns[4].HeaderText = "Дата";
                dataGridView.Columns[5].HeaderText = "Время";
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
}
    }
}
