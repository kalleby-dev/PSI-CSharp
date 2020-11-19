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

            for (int column = 0; column < COLUMN_MAX; column++)
            {
                for (int row = 0; row < ROW_MAX; row++)
                {
                    double value = randf.NextDouble() * 50;
                    value = (double)Decimal.Round((decimal)value, 2);
                    numeros[column, row] = value;
                    tblNumeros[column, row].Value = value;
                }
            }
        }

        public void updateButtons(bool state = false)
        {
            state = (state == false) ? !this.btnModa.Enabled : true;

            this.btnModa.Enabled = state;
            this.btnMedia.Enabled = state;
            this.btnMinimo.Enabled = state;
            this.btnMaximo.Enabled = state;
        }

        public void clearScreen()
        {
            for(int column = 0; column < COLUMN_MAX; column++)
            {
                for(int row = 0; row < ROW_MAX; row++)
                {
                    numeros[column, row] = 0;
                    tblNumeros[column, row].Value = "";
                }
            }

            this.lblMax.Text = "";
            this.lblMin.Text = "";
            this.lblModa.Text = "";
            this.lblMedia.Text = "";
            this.updateButtons();
        }

        public int countNumber(int number)
        {
            List<int> values = new List<int> { };
            foreach (double value in numeros)
            {
                values.Add((int)value);
            }

            return values.Count(n => n == number);
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.createRandom();
            this.updateButtons(true);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (double value in numeros)
            {
                total += value;
            }
            total /= numeros.Length;
            total = (double)Decimal.Round((decimal)total, 2);
            this.lblMedia.Text = total.ToString();
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            double min = numeros[0, 0];
            foreach (double value in numeros)
            {
                min = (value < min) ? value : min;
            }
            this.lblMin.Text = min.ToString();
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            double max = numeros[0, 0];
            foreach (double value in numeros)
            {
                max = (value > max) ? value : max;
            }
            this.lblMax.Text = max.ToString();
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            int moda = 0;
            int count = 0;
            foreach (double value in numeros)
            {
                int atual = countNumber((int)value);
                if (atual > count)
                {
                    count = atual;
                    moda = (int)value;
                }
            }
            this.lblModa.Text = moda.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
