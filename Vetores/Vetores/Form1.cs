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

namespace Vetores
{
    public partial class Form1 : Form
    {
        // Declaracao e criacao dos vetores
        private int[] vetor1 = new int[10];
        private int[] vetor2 = new int[10];

        // Variaveis que controlam a posicao dos vetores
        private int pos1 = 0;
        private int pos2 = 0;
        public Form1()
        {
            InitializeComponent();
            this.updateDisplay();
        }

        public void updateDisplay()
        {
            this.lblValor1.Text = pos1.ToString();
            this.lblValor2.Text = pos2.ToString();
        }

        public void displayError(String message = "")
        {
            message = (message == "") ? "Houve um erro" : message;
            MessageBox.Show(message);
        }

        public void allowInsert()
        {
            this.txtValor1.Enabled = (this.pos1 > 9) ? false : true;
            this.btnValor1.Enabled = (this.pos1 > 9) ? false : true;

            this.txtValor2.Enabled = (this.pos2 > 9) ? false : true;
            this.btnValor2.Enabled = (this.pos2 > 9) ? false : true;
        }

        public int displayList(int[] vetor, ListBox list, int index = 0)
        {
            list.Items.Add(vetor[index]);
            return (index < 9)? this.displayList(vetor, list, ++index) : index;
        }

        // Retorna um vetor com o resultado da soma dos outros vetores
        public int[] sumArray(int[] vetor1, int[] vetor2, int[] result = null, int max = 0,int index = 0)
        {
            // Descobre o maximo ou utiliza o valor passado como argumento
            max = (vetor1.Length == vetor2.Length) ? vetor1.Length : max;

            result = (result == null) ? new int[max] : result;
            result[index] = vetor1[index] + vetor2[index];

            return (index < max -1) ? this.sumArray(vetor1, vetor2, result, max, ++index) : result;
        }


        private void btnValor1_Click(object sender, EventArgs e)
        { 
            bool isNumber = int.TryParse(this.txtValor1.Text, out this.vetor1[this.pos1]);
            this.txtValor1.ResetText();
            this.txtValor1.Focus();

            if (isNumber == false)
            {
                this.displayError("Valor invalido");
                return;
            }


            pos1++;
            this.updateDisplay();
            this.allowInsert();
        }

        private void btnValor2_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(this.txtValor2.Text, out this.vetor2[this.pos2]);
            this.txtValor2.ResetText();
            this.txtValor2.Focus();

            if (isNumber == false)
            {
                this.displayError("Valor invalido");
                return;
            }

            pos2++;
            this.updateDisplay();
            this.allowInsert();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.pos1 < 10 || this.pos2 < 10) return;

            this.listValor1.Items.Clear();
            this.listValor2.Items.Clear();

            this.displayList(this.vetor1, this.listValor1);
            this.displayList(this.vetor2, this.listValor2);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (this.pos1 < 10 || this.pos2 < 10) return;
            this.listSum.Items.Clear();

            int[] result = this.sumArray(this.vetor1, this.vetor2);
            this.displayList(result, this.listSum);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.listSum.Items.Clear();
            this.listValor1.Items.Clear();
            this.listValor2.Items.Clear();
            this.pos1 = 0;
            this.pos2 = 0;
            this.allowInsert();
            this.updateDisplay();
        }
    }
}
