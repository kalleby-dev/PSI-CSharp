using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX7_SmilesCartas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = true;
            this.imgBox.Image = Properties.Resources.happy;
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = true;
            this.imgBox.Image = Properties.Resources.sad;
        }

        private void imgBox_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = false;
        }

        private void espadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = true;
            this.imgBox.Image = Properties.Resources.espadas;
        }

        private void copasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = true;
            this.imgBox.Image = Properties.Resources.copas;
        }

        private void ouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = true;
            this.imgBox.Image = Properties.Resources.ouro;
        }

        private void pausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imgBox.Visible = true;
            this.imgBox.Image = Properties.Resources.paus;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
