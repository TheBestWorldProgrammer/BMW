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
    public partial class Form1 : Form
    {
        public ProverkaDataSet db = new ProverkaDataSet();
        public Form1()
        {
            InitializeComponent();
            var query = (from d in db.subjects select d.name_subj).ToArray();
            string[] mass = new string[query.Length];
            for (int i=0; i<query.Length;i++)
            {
                mass[i] = query[i].ToString();
            ListViewItem lvItem = new ListViewItem(new string[] { mass[i] });
            listView1.Items.Add(lvItem);
            }
           
        }
    }
}
