﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public demoEntities db=new demoEntities();
        public List<students> studentsheet;       
        public Form1()
        {
            InitializeComponent();
            studentsheet = (from stud in db.students select stud).ToList();          
            var query = (from stud in studentsheet
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, stud.code_group }).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
            dataGridView1.Columns[0].HeaderText = "Номер студента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Номер группы";
            dataGridView1.Columns[4].HeaderText = "Код группы";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from stud in db.students
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, stud.code_group }).ToList();
           
            if (textBox1.Text!="")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = query.Where(p => p.code_stud.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;
                    case 1:
                        dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;
                    case 2:
                        dataGridView1.DataSource = query.Where(p => p.name.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;
                    case 3:
                        dataGridView1.DataSource = query.Where(p => p.name_group.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;
                   
                }

            }
            else
            {
                dataGridView1.DataSource = query;
            }
            dataGridView1.Update();
            if (dataGridView1.RowCount == 0) label1.Visible = true; else label1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                FormAddStudent addSt = new FormAddStudent();
                addSt.Owner = this;
                addSt.Show();
            }
            else
                Application.OpenForms[1].Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<students> query = (from stud in db.students select stud).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
                if (Application.OpenForms.Count == 2)
                {
                    students item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    FormEditStudent editSt = new FormEditStudent(item);
                    editSt.Owner = this;
                    editSt.Show();
                }
                else Application.OpenForms[1].Focus();


        }

        private void button4_Click(object sender, EventArgs e)
        { 
            var query = (from stud in studentsheet join g in db.groups on stud.code_group equals g.code_group orderby stud.code_stud select new { stud.code_stud, stud.surname, stud.name, g.name_group, stud.code_group }).ToList();
            dataGridView1.DataSource = query;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
       
            SaveFileDialog dialog = new SaveFileDialog(); dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";
            dialog.Filter = "Таблицы Excel (*xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create,FileAccess.ReadWrite);
            
            var query = (from stud in db.students
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, stud.code_group }).ToList();
            var template = new MemoryStream(Properties.Resources.template, true);
            var workbook = new XSSFWorkbook(template);
            var sheet1 = workbook.GetSheet("Лист1");
            var row = 12;
           
                foreach (var item in query.OrderBy(o => o.code_stud))

                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(1).SetCellValue(item.code_stud);
                    rowInsert.CreateCell(2).SetCellValue(item.surname);
                    rowInsert.CreateCell(3).SetCellValue(item.name);
                    rowInsert.CreateCell(4).SetCellValue(item.name_group);
                    row++;
                }
                workbook.Write(file);

            }
        }
    }
}
