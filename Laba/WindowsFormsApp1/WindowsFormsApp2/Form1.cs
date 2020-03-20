using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripComboBox1.Text);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
