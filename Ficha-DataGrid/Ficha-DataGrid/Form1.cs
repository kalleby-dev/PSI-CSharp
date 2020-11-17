using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_DataGrid
{
    public partial class Form1 : Form
    {
        private const int ROW_MAX = 10;
        private const int COLUMN_MAX = 5;
        private double[,] numeros = new double[5, 10];

        public Form1()
        {
            InitializeComponent();
            this.tblNumeros.Rows.Add(9);
        }

        public void createRandom()
        {
            Random randf = new Random();
            
            for(int column = 0; column < COLUMN_MAX; column++)
            {
                for(int row = 0; row < ROW_MAX; row++)
                {
                    double value = randf.NextDouble() * 50;
                    value = (double) Decimal.Round((decimal)value, 2);
                    numeros[column, row] = value;
                    tblNumeros[column, row].Value = value;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.createRandom();
        }
    }
}
