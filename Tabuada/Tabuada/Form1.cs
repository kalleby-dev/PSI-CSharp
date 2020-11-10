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

namespace Tabuada
{
    public partial class Form1 : Form
    {
        private int numero;
        public Form1()
        {
            InitializeComponent();
        }

        protected void tabuada()
        {
            for(int i = 1; i <= 10; i++)
            {
                this.listResult.Items.Add($"{this.numero} X {i} = {this.numero * i}");
            }
        }

        protected int tabuadaRecursiva(int num, int i = 1)
        {
            this.listResult.Items.Add($"{num} X {i} = {num * i}");
            
            return (i < 10) ? tabuadaRecursiva(num, ++i) : num;
        }

        private void cmbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(this.cmbNumero.Text, out this.numero);
            this.listResult.Items.Clear();
            tabuadaRecursiva(this.numero);
            // this.tabuada();
        }
    }
}
