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
            this.temperatura = (this.temperatura >= 100) ? 100 : this.temperatura;
            this.temperatura = (this.temperatura <= 0) ? 0 : this.temperatura;

            this.scrTemperatura.Value = this.temperatura;
            this.txtTemperatura.Text = $"{ this.temperatura } Graus";
        }

        private void scrTemperatura_Scroll(object sender, ScrollEventArgs e)
        {
            this.temperatura = this.scrTemperatura.Value;
            this.updateTemp();
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            String text = this.txtTemperatura.Text;
            var split = text.Split(' ');
            
            System.Diagnostics.Debug.WriteLine(split[0]);

            int.TryParse(split[0], out this.temperatura);
            this.updateTemp();
        }
    }
}
