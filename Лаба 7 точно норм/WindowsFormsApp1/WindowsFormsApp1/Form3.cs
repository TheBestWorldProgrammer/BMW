using System;
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
    public partial class Form3 : Form
    {
       
            public demoEntities db = new demoEntities();      
            public List<progress> progressheet;
            public Form3()
            {
                InitializeComponent();
              
                progressheet = (from prog in db.progress select prog).ToList();
            var query = (from prog in db.progress
                          join stud in db.students on prog.code_stud equals stud.code_stud
                          join subj in db.subjects on prog.code_subject equals subj.code_subject
                          join lec in db.lectors on prog.code_lector equals lec.code_lector
                          orderby prog.code_stud
                          select new { prog.code_stud, stud.surname, stud.name, subj.name_subject, prog.date_exam, prog.estimate, lec.name_lector, prog.code_subject }).ToList();
            dataGridView1.DataSource = query;
                dataGridView1.ReadOnly = true;
                if (dataGridView1.RowCount == 0) label1.Visible = true;
                else label1.Visible = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Фамилия студента";
                dataGridView1.Columns[2].HeaderText = "Имя студента";
                dataGridView1.Columns[3].HeaderText = "Название предмета";
                dataGridView1.Columns[4].HeaderText = "Дата экзамена";
                dataGridView1.Columns[5].HeaderText = "Оценки";
                dataGridView1.Columns[6].HeaderText = "Имя преподавателя";
                dataGridView1.Columns[7].Visible = false;

        }

            private void button1_Click(object sender, EventArgs e)
            {
            var query = (from prog in db.progress
                         join stud in db.students on prog.code_stud equals stud.code_stud
                         join subj in db.subjects on prog.code_subject equals subj.code_subject
                         join lec in db.lectors on prog.code_lector equals lec.code_lector
                         orderby prog.code_stud
                         select new { stud.surname, stud.name, subj.name_subject, prog.date_exam, prog.estimate, lec.name_lector }).ToList();

            if (textBox1.Text != "")
                {
                    switch (comboBox1.SelectedIndex)
                    {
                    case 0:
                        dataGridView1.DataSource = query.Where(p => p.name_lector.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;
                    case 1:
                        dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;
                    case 2:
                        dataGridView1.DataSource = query.Where(p => p.name_subject.ToString() == textBox1.Text.Trim().ToString()).ToList(); break;

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
                    FormAddProg addSt = new FormAddProg();
                    addSt.Owner = this;
                    addSt.Show();
                }
                else
                    Application.OpenForms[1].Focus();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                List<progress> query = (from prog in db.progress select prog).ToList();
                if (dataGridView1.SelectedCells.Count == 1)
                    if (Application.OpenForms.Count == 2)
                    {
                    progress item = query.First(z => z.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString() && z.code_subject.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value.ToString());
                    FormEditProg editSt = new FormEditProg(item);
                        editSt.Owner = this;
                        editSt.Show();
                    }
                    else Application.OpenForms[1].Focus();


            }

            private void button4_Click(object sender, EventArgs e)
            {
                var query = (from prog in db.progress
                             join s in db.students on prog.code_stud equals s.code_stud
                             join sub in db.subjects on prog.code_subject equals sub.code_subject
                             join l in db.lectors on prog.code_lector equals l.code_lector
                             orderby prog.code_stud
                             select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector }).ToList();
                dataGridView1.DataSource = query;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";
            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                var query = (from prog in db.progress
                             join s in db.students on prog.code_stud equals s.code_stud
                             join sub in db.subjects on prog.code_subject equals sub.code_subject
                             join l in db.lectors on prog.code_lector equals l.code_lector
                             orderby prog.code_stud
                             select new { prog.code_stud, s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector, prog.code_subject }).ToList();
                var template = new MemoryStream(Properties.Resources.template2);
                var workbook = new XSSFWorkbook(template);
                var sheet1 = workbook.GetSheet("Лист1");

                int row = 9;
                foreach (var item in query.OrderBy(o => o.date_exam))
                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(0).SetCellValue(item.surname);
                    rowInsert.CreateCell(1).SetCellValue(item.name);
                    rowInsert.CreateCell(2).SetCellValue(item.name_subject);
                    rowInsert.CreateCell(3).SetCellValue(item.date_exam);
                    rowInsert.CreateCell(4).SetCellValue((double)item.estimate);
                    rowInsert.CreateCell(5).SetCellValue(item.name_lector);
                    row++;

                }
                workbook.Write(file);
            }
        }
    }
    }
