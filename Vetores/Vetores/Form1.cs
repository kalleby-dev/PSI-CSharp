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

        private void btnValor1_Click(object sender, EventArgs e)
        { 
            bool isNumber = int.TryParse(this.txtValor1.Text, out this.vetor1[this.pos1]);
            this.txtValor1.ResetText();
            if (isNumber == false)
            {
                this.displayError("Valor invalido");
                return;
            }


            pos1++;
            this.updateDisplay();
            this.txtValor1.Enabled = (this.pos1 > 9)? false: true;
            this.btnValor1.Enabled = (this.pos1 > 9)? false: true;
        }
    }
}
