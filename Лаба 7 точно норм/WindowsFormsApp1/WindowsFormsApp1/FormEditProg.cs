﻿using System;
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
    public partial class FormEditProg : Form
    {
        public demoEntities db = new demoEntities();
        progress item;
        public FormEditProg(progress prog)
        {
            InitializeComponent();
            item = prog;
            textBox1.Text = item.estimate.ToString();
            numericUpDown1.Value = item.date_exam.Day;
            numericUpDown2.Value = item.date_exam.Month;
            numericUpDown3.Value = item.date_exam.Year;
            textBox2.Text = item.students.surname.ToString();
            textBox3.Text = item.students.name.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Form3)Owner).db.progress.SingleOrDefault(w => w.code_stud == item.code_stud && w.code_subject == item.code_subject);
            result.estimate = Convert.ToInt32(textBox1.Text);
            result.date_exam = new DateTime((int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown1.Value);
            ((Form3)Owner).progressheet = ((Form3)Owner).db.progress.OrderBy(o => o.code_stud).ToList();
            ((Form3)Owner).db.SaveChanges();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
