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
    public class FuncMath
    {
        public Func<float, float, float> MathFunc { get; set; }
    }
    public partial class Form1 : Form
    {
        private String currentText = "";
        private float currentTotal = 0;

        private Dictionary<String, FuncMath> operations = new Dictionary<string, FuncMath>();
        public Form1()
        {
            InitializeComponent();
            this.initButtons();
            this.initOperations();
            this.clearDisplay();
        }

        protected void initButtons()
        {
            for(int i = 0; i < 10; i++)
            {
                Button btn = this.numPanel.Controls[$"btn{i}"] as Button;
                btn.Click += this.btnNumClick;
            }

            for(int i = 1; i <= 4; i++)
            {
                Button btn = this.mathPanel.Controls[$"btnMath{i}"] as Button;
                btn.Click += this.btnMathClick;
            }
        }

        public void initOperations()
        {
            this.operations.Add("+", new FuncMath());
            this.operations["+"].MathFunc = (numberA, numberB) => numberA + numberB;

            this.operations.Add("-", new FuncMath());
            this.operations["-"].MathFunc = (numberA, numberB) => numberA - numberB;

            this.operations.Add("x", new FuncMath());
            this.operations["x"].MathFunc = (numberA, numberB) => numberA * numberB;

            this.operations.Add("/", new FuncMath());
            this.operations["/"].MathFunc = (numberA, numberB) => numberA / numberB;
            // Debug.WriteLine(this.operations["+"].MathFunc(2, 2));
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

        protected void btnMathClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            String operation = btn.Text;
            float.TryParse(this.currentText, out float currentNumber);
            


            Debug.WriteLine("Math click");
        }
    }
}
