using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMelhorada
{
    public partial class Form1 : Form
    {
        private String currentText = "";
        public Form1()
        {
            InitializeComponent();
            this.clearDisplay();
        }

        public void clearDisplay()
        {
            this.currentText = "";
            this.updateDisplay();
        }

        public void updateDisplay()
        {
            this.lblDisplay.Text = this.currentText;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearDisplay();
        }
    }
}
