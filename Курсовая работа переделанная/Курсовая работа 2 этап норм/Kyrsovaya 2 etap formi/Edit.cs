using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kyrsovaya_2_etap_formi
{
    class Edit
    {
        public Edit() { }
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        
        public void EditEst(NumericUpDown numericUpDown1, ComboBox comboBox1, estimate item)
        {
            
            var result = db.estimate.SingleOrDefault(w => w.code_shedule == item.code_shedule);
            result.name_est = numericUpDown1.Value.ToString();
            var query = (from g in db.shedule where g.code_shedule.ToString() == comboBox1.SelectedItem.ToString() select g.code_shedule).ToList();
            result.code_shedule = query[0];
            db.SaveChanges();
        }
        public  void EditSal(NumericUpDown numericUpDown1, NumericUpDown numericUpDown2, NumericUpDown numericUpDown3, ComboBox comboBox1, ComboBox comboBox2, salary item)
        {
            var result = db.salary.SingleOrDefault(w => w.code_salary == item.code_salary);
            result.experience = Convert.ToInt32(numericUpDown2.Value);
            result.work_hour = Convert.ToInt32(numericUpDown3.Value);
            result.summ = Convert.ToInt32(numericUpDown1.Value);
            result.mounth = comboBox2.Text;
            var query = (from g in db.lectors where g.surname_lector == comboBox1.SelectedItem.ToString() select g.code_lector).ToList();
            result.code_lector = query[0];
            db.SaveChanges();
        }
        public void EditShd(DateTimePicker dateTimePicker1, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4,shedule item)
        {
            
                var result = db.shedule.SingleOrDefault(w => w.code_shedule == item.code_shedule);
                var query = (from g in db.students where g.surname_stud == comboBox1.SelectedItem.ToString() select g.code_stud).ToList();
                result.code_stud = query[0];
                var query1 = (from g in db.subjects where g.name_subj == comboBox3.SelectedItem.ToString() select g.code_subject).ToList();
                result.code_subject = query1[0];
                var query2 = (from g in db.lectors where g.surname_lector == comboBox2.SelectedItem.ToString() select g.code_lector).ToList();
                result.code_lector = query2[0];
                result.time_classes = comboBox4.SelectedItem.ToString();
                result.date_classes = dateTimePicker1.Value;
                db.SaveChanges();
            
        }
        public void EditStud(DateTimePicker dateTimePicker1, TextBox textBox1, TextBox textBox2, TextBox textBox3, ComboBox comboBox1, students item)
        {
            if (dateTimePicker1.Value.AddYears(6) > DateTime.Now)
                MessageBox.Show("Ученику меньше 6 лет");
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Одно из полей пустое. Пожалуйста заполните информацию");

            else
            {
                var result = db.students.SingleOrDefault(w => w.code_stud == item.code_stud);
                result.surname_stud = textBox2.Text.ToString();
                result.name_stud = textBox1.Text.ToString();
                result.lastname_stud = textBox3.Text.ToString();
                result.birthday_stud = dateTimePicker1.Value.ToUniversalTime();
                var query = (from g in db.parents where g.surname_parent == comboBox1.SelectedItem.ToString() select g.code_parent).ToList();
                result.code_parent = query[0];
                db.SaveChanges();
            }
        }
        public void EditTeach(DateTimePicker dateTimePicker1, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox5, lectors item)
        {
            if (dateTimePicker1.Value.AddYears(20) > DateTime.Now)
                MessageBox.Show("Учителю меньше 20 лет");
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
                MessageBox.Show("Одно из полей пустое. Пожалуйста заполните информацию");
            else
            {
                var result = db.lectors.SingleOrDefault(w => w.code_lector == item.code_lector);
                result.surname_lector = textBox1.Text.ToString();
                result.name_lector = textBox2.Text.ToString();
                result.lastname_lector = textBox3.Text.ToString();
                result.birthday_lector = dateTimePicker1.Value;
                result.post = textBox5.Text.ToString();
                db.SaveChanges();
            }
        }
    }
}
