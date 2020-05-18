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
    public partial class AddStudent : Form
    {
        public SchoolEntitiesTrue db = new SchoolEntitiesTrue();
        public AddStudent()
        {
            InitializeComponent();
           
            var groups_for_list = (from g in db.parents select g.surname_parent).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.schoolDataSet2.parents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var query = (from g in db.parents where g.surname_parent == comboBox1.SelectedItem.ToString() select g.code_parent).ToList();
                int number_of_student = db.students.Max(n => n.code_stud) + 1;
                students new_student = new students { code_stud = number_of_student, surname_stud = textBox1.Text, name_stud = textBox2.Text, lastname_stud = textBox3.Text, birthday_stud = Convert.ToDateTime(dateTimePicker1.Value), code_parent = query[0] };
                ((Main)Owner).db.students.Add(new_student);
                ((Main)Owner).studentsheet = ((Main)Owner).db.students.OrderBy(o => o.code_stud).ToList();
                ((Main)Owner).db.SaveChanges();
                this.Close();
            
           
        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void button3_Click(object sender, EventArgs e)
        {
            Form f7 = new AddParent();
            f7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {          
            comboBox1.Items.Clear();
            var groups_for_list = (from g in db.parents select g.surname_parent).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);
        }
    }
}
