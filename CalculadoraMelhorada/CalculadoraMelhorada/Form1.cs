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
        private String currentOperation = "";

        private float tempValue = 0;
        private float currentValue = 0;
        private float currentTotal = 0;
        

        private Dictionary<String, FuncMath> operations = new Dictionary<string, FuncMath>();
        public Form1()
        {
            InitializeComponent();
            this.initButtons();
            this.initOperations();
            this.updateDisplay("");
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
        }

        public float calc(float n1, float n2)
        {
            bool isOption = this.operations.TryGetValue(this.currentOperation, out FuncMath option);
            if (isOption == false) return 0;

            return option.MathFunc(n1, n2);
        }

        public void saveTemp()
        {

            this.tempValue = this.currentValue;
            this.currentValue = 0;
            this.currentTotal = (this.currentTotal == 0)? tempValue : this.calc(this.currentTotal, this.tempValue);
            Debug.WriteLine(currentTotal);
        }

        public void resetValues()
        {
            this.tempValue = 0;
            this.currentValue = 0;
            this.currentTotal = 0;
            this.currentOperation = "";
        }

        public void updateDisplay(String text = null)
        {
            this.currentText = (text == null)? this.currentText : text;
            this.lblDisplay.Text = this.currentText;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.updateDisplay("");
            this.resetValues();
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

            this.currentOperation = btn.Text;
            float.TryParse(this.currentText, out this.currentValue);

            this.saveTemp();
            this.updateDisplay("");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            float.TryParse(this.currentText, out this.currentValue);

            this.saveTemp();
            this.updateDisplay(this.currentTotal.ToString());
            this.resetValues();
        }
    }

    public class FuncMath
    {
        public Func<float, float, float> MathFunc { get; set; }
    }
}
