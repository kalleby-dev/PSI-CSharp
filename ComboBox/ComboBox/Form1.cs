using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
        }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblCity.Text = this.cmbList.Text;
        }

        private void btnBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCity.BackColor = Color.Aquamarine;
        }

        private void btnRed_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCity.BackColor = Color.IndianRed;
        }

        private void btnGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCity.BackColor = Color.GreenYellow;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.lblScroll.Text = this.hScrollBar1.Value.ToString();
        }
    }
}
