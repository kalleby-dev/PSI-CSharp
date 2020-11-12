using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid1
{
    public partial class Form1 : Form
    {
        private int linha = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dgvLista.Rows.Add();
            this.dgvLista[0, linha].Value = txtValor1.Text;
            this.dgvLista[1, linha].Value = txtValor2.Text;

            txtValor1.Clear();
            txtValor2.Clear();
            linha++;
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblResult1.Text = this.dgvLista[0, e.RowIndex].Value.ToString();
            this.lblResult2.Text = this.dgvLista[1, e.RowIndex].Value.ToString();
        }
    }
}
