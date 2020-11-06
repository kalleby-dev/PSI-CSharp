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

namespace CalculadoraMelhorada
{
    public partial class Form1 : Form
    {
        private String currentText = "";
        public Form1()
        {
            InitializeComponent();
            this.initButtons();
            this.clearDisplay();
        }

        protected void initButtons()
        {
            for(int i = 0; i < 10; i++)
            {
                Button btn = this.numPanel.Controls[$"btn{i}"] as Button;
                btn.Click += this.btnNumClick;
            }
            
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
           
        protected void btnNumClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.currentText += btn.Text;
            this.updateDisplay();
        }
    }
}
