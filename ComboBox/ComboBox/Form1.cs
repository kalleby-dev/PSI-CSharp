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
    }
}
