using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private const int PAR = 2;

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
                    tblNumeros[coluna, linha].Value = (this.numeros[coluna, linha] == 0) ? null : this.numeros[coluna, linha].ToString();
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
                this.btnCalc.Enabled = true;
                return;
            }

            this.lblColumns.Text = this.coluna.ToString();
            this.lblRows.Text = this.linha.ToString();
        }

        public int sumPares()
        {
            int result = 0;
            foreach(int value in numeros)
            {
                result += ((value % PAR) == 0)? value : 0;
            }
            return result;
        }

        public int sumImpar()
        {
            int result = 0;
            foreach (int value in numeros)
            {
                result += ((value % PAR) != 0) ? value : 0;
            }
            return result;
        }

        public int sumDiagonal()
        {
            int result = numeros[0, 0] + numeros[1, 1] + numeros[2, 2];
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (linha > MAX) return;
            bool isNumber = int.TryParse(this.txtValue.Text, out this.numeros[coluna-1, linha-1]);

            if (isNumber == false) return;

            this.updateTable();
            this.countTable();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.lblPares.Text = this.sumPares().ToString();
            this.lblImpar.Text = this.sumImpar().ToString();
            this.lblDiagonal.Text = this.sumDiagonal().ToString();
        }
    }
}
