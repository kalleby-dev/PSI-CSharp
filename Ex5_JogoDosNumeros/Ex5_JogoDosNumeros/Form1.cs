using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5_JogoDosNumeros
{
    public partial class Form1 : Form
    {
        private const int MAX = 9;
        private const int MIN = 1;
        private int score = 100;
        public Form1()
        {
            InitializeComponent();
            updateScore();
        }

        public void reset()
        {
            this.score = 100;
            this.updateScore();
        }

        public void lose()
        {
            LoseForm lose = new LoseForm();
            lose.Show();
        }

        public void win()
        {
            WinnerForm winner = new WinnerForm();
            winner.Show();
        }

        public void updateScore()
        {
            this.lblScore.Text = this.score.ToString();
            if(this.score <= 0)
            {
                this.reset();
                this.lose();
            }
            if(this.score >= 200)
            {
                this.reset();
                this.win();
            }
        }

        public void displayNumbers(int[] numbers)
        {
            // Pega as Labels atraves do nome, dinamicamente
            for (int i = 0; i < numbers.Length; i++)
            {
                Label label = this.Controls["lblN" + (i + 1)] as Label;
                label.Text = numbers[i].ToString();
            }
        }


        public int[] createRandom()
        {
            // Retorna um array com valores aleatorios
            Random randi = new Random();
            int[] result = new int[3];

            for(int i = 0; i < result.Length; i++) {
                result[i] = randi.Next(MIN, MAX);
            }
            return result;
        }

        public void setScore(int match)
        {
            // Aplica a pontuação com base no numero de correspondencias
            Dictionary<int, int> matches = new Dictionary<int, int>
            {
                {0, -5},
                {1, 10},
                {2, 25},
                {3, 50},
            };
            this.score += matches[match];
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int choose = int.Parse(this.txtNumber.Text);
            int[] numbers = this.createRandom();
            this.displayNumbers(numbers);

            // Aplica as regras do jogo
            int matches = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(choose == numbers[i])
                {
                    matches++;
                }
            }

            this.setScore(matches);
            this.updateScore();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            RulesForm regras = new RulesForm();
            regras.Show();
        }
    }
}
