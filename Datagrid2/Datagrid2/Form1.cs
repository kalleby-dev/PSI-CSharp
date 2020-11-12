using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagrid2
{
    public partial class Form1 : Form
    {
        private const int MAX = 3;
        private const int MIN = 1;

        private int[,] numeros = new int[MAX, MAX];
        private int coluna = MIN;
        private int linha = MIN;

        
        public Form1()
        {
            InitializeComponent();
            this.tblNumeros.Rows.Add(2);
            this.lblColumns.Text = this.coluna.ToString();
            this.lblRows.Text = this.linha.ToString();
        }

        public void updateTable()
        {
            for(int coluna = 0; coluna < MAX; coluna++)
            {
                for(int linha = 0; linha < MAX; linha++)
                {
                    this.tblNumeros[coluna, linha].Value = this.numeros[coluna, linha];
                }
            }
        }

        public void countTable()
        {
            linha = (coluna == MAX) ? ++linha : linha;
            coluna = (coluna == MAX) ? MIN : ++coluna;

            if (linha > MAX)
            {
                this.txtValue.Enabled = false;
                this.btnAdd.Enabled = false;
                return;
            }

            this.lblColumns.Text = this.coluna.ToString();
            this.lblRows.Text = this.linha.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (linha > MAX) return;
            int.TryParse(this.txtValue.Text, out this.numeros[coluna-1, linha-1]);
            this.updateTable();
            this.countTable();
        }
    }
}
