using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_5_Temperatura
{
    public partial class Form1 : Form
    {
        private int temperatura = 50;
        public Form1()
        {
            InitializeComponent();
            this.updateTemp();
        }

        public void updateTemp()
        {
            this.txtTemperatura.Text = $"{ this.temperatura }";
            this.scrTemperatura.Value = this.temperatura;
        }

        private void scrTemperatura_Scroll(object sender, ScrollEventArgs e)
        {
            this.temperatura = this.scrTemperatura.Value;
            this.updateTemp();
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            /*String text = this.txtTemperatura.Text;
            var split = text.Split(' ');
            Console.WriteLine(split);
            int.TryParse(this.txtTemperatura.Text, out this.temperatura);
            this.updateTemp();*/
        }
    }
}
