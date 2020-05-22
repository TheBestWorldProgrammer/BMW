using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kyrsovaya_2_etap_formi
{
    class Add
    {
        public Add() { }
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public void AddEst(NumericUpDown numericUpDown1, ComboBox comboBox1)
        {
            int number_of_estimate = 1;
            var query = (from g in db.shedule where g.code_shedule == (int)comboBox1.SelectedItem select g.code_shedule).ToList();
            number_of_estimate = db.estimate.Max(n => n.code_est) + 1;
            estimate new_estimate = new estimate { code_est = number_of_estimate, name_est = numericUpDown1.Value.ToString(), code_shedule = query[0] };
            db.estimate.Add(new_estimate);
            db.SaveChanges();
            
        }

        public void AddPar(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Одно из полей пустое. Пожалуйста заполните информацию");
            else
            {
                int number_of_parent = db.parents.Max(n => n.code_parent) + 1;
                parents new_parent = new parents { code_parent = number_of_parent, surname_parent = textBox1.Text, name_parent = textBox2.Text, lastname_parent = textBox3.Text, adress = textBox4.Text };
                db.parents.Add(new_parent);
                db.SaveChanges();
               
            }
        }
        public void AddSal(ComboBox comboBox1,ComboBox comboBox2, NumericUpDown numericUpDown1, NumericUpDown numericUpDown2, NumericUpDown numericUpDown3)
        {
            var query = (from g in db.lectors where g.surname_lector == comboBox1.SelectedItem.ToString() select g.code_lector).ToList();
            int number_of_salary = db.salary.Max(n => n.code_salary) + 1;
            salary new_salary = new salary { code_salary = number_of_salary, code_lector = query[0], experience = Convert.ToInt32(numericUpDown2.Value), work_hour = Convert.ToInt32(numericUpDown3.Value), summ = Convert.ToInt32(numericUpDown1.Value), mounth = comboBox2.Text };
            db.salary.Add(new_salary);
            db.SaveChanges();
        }
        public void AddShd(DateTimePicker dateTimePicker1, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4)
        {
            if (dateTimePicker1.Value < DateTime.Now)
                MessageBox.Show("Дата добавления расписания меньше текущей. Пожалуйста выберите другую дату");
            else
            {
                var query = (from g in db.students where g.surname_stud == comboBox1.SelectedItem.ToString() select g.code_stud).ToList();
                var query1 = (from g in db.lectors where g.surname_lector == comboBox2.SelectedItem.ToString() select g.code_lector).ToList();
                var query2 = (from g in db.subjects where g.name_subj == comboBox3.SelectedItem.ToString() select g.code_subject).ToList();
                int number_of_shedule = db.shedule.Max(n => n.code_shedule) + 1;
                shedule new_shedule = new shedule { code_shedule = number_of_shedule, code_stud = query[0], code_subject = query2[0], code_lector = query1[0], date_classes = dateTimePicker1.Value, time_classes = comboBox4.SelectedItem.ToString() };
                db.shedule.Add(new_shedule);
                db.SaveChanges();
            }
        }
        public void AddStud(DateTimePicker dateTimePicker1, TextBox textBox1, TextBox textBox2,TextBox textBox3, ComboBox comboBox1)
        {
            if (dateTimePicker1.Value.AddYears(6) > DateTime.Now)
                MessageBox.Show("Ученику меньше 6 лет");
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Одно из полей пустое. Пожалуйста заполните информацию");

            else
            {
                var query = (from g in db.parents where g.surname_parent == comboBox1.SelectedItem.ToString() select g.code_parent).ToList();
                int number_of_student = db.students.Max(n => n.code_stud) + 1;
                students new_student = new students { code_stud = number_of_student, surname_stud = textBox2.Text, name_stud = textBox1.Text, lastname_stud = textBox3.Text, birthday_stud = Convert.ToDateTime(dateTimePicker1.Value), code_parent = query[0] };
                db.students.Add(new_student);
                db.SaveChanges();
                
            }
        }
        public void AddSub(TextBox textBox2)
        {
            if (textBox2.Text == "")
                MessageBox.Show("Одно из полей пустое. Пожалуйста заполните информацию");
            else
            {
                int number_of_sublect = db.subjects.Max(n => n.code_subject) + 1;
                subjects new_subject = new subjects { code_subject = number_of_sublect, name_subj = textBox2.Text };
                db.subjects.Add(new_subject);
                db.SaveChanges();
               
            }
        }
        public void AddTeach(DateTimePicker dateTimePicker1, TextBox textBox1, TextBox textBox2,TextBox textBox3, TextBox textBox5)
        {
            if (dateTimePicker1.Value.AddYears(20) > DateTime.Now)
                MessageBox.Show("Учителю меньше 20 лет");
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
                MessageBox.Show("Одно из полей пустое. Пожалуйста заполните информацию");

            else
            {
                int number_of_lector = db.lectors.Max(n => n.code_lector) + 1;
                lectors new_lector = new lectors { code_lector = number_of_lector, surname_lector = textBox1.Text, name_lector = textBox2.Text, lastname_lector = textBox3.Text, birthday_lector = Convert.ToDateTime(dateTimePicker1.Value), post = textBox5.Text };
                db.lectors.Add(new_lector);
                db.SaveChanges();
               
            }
        }
    }
}
