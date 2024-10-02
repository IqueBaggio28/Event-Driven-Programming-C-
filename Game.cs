using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Math_Game
{



    public partial class Game : Form
    {
        int first, second, diff, result, sequence = 0, correct = 0, incorrect = 0;
        char[] operations = { '+', '-', '*', '/', '%' };
        char operation;

        public Game()
        {
            InitializeComponent();
        }

        public Game(int difficulty)
        {
            InitializeComponent();

            diff = difficulty;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close only the Game form
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtInput.Text.Contains("."))
            {
                e.Handled = true;
            }

        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
            }
        }


        private void Game_Load(object sender, EventArgs e)
        {
            generateEquation();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }




        public void generateEquation()
        {

            Random rand = new Random();
            operation = operations[rand.Next(operations.Length)]; // Use all operations
            switch (diff)
            {
                case 1: // Easy
                    first = rand.Next(10, 50); // Numbers between 10 and 50
                    second = rand.Next(1, 10); // Numbers between 1 and 10
                    break;

                case 2: // Medium
                    first = rand.Next(50, 100); // Numbers between 50 and 100
                    second = rand.Next(10, 50); // Numbers between 10 and 50
                    break;

                case 3: // Hard
                    first = rand.Next(100, 500); // Numbers between 100 and 500
                    second = rand.Next(50, 100); // Numbers between 50 and 100
                    break;
            }

            // Calculate the result based on the selected operation
            switch (operation)
            {
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    result = first / second;
                    break;
                case '%':
                    result = first % second;
                    break;
            }

            // Update UI with the generated question
            lblFirst.Text = first.ToString();
            lblOperation.Text = operation.ToString();
            lblSecond.Text = second.ToString();
            lblCorrect.Text = correct.ToString();
            lblIncorrect.Text = incorrect.ToString();
        }


        private void checkAnswer()
        {

            if (int.TryParse(txtInput.Text, out int input))
            {
                if (input == result)
                {
                    correct += 1;
                    lblCorrectIncorrect.Text = "Correct!";
                    lblCorrectIncorrect.ForeColor = Color.Green;
                    lblCorrect.Text = correct.ToString();
                    txtInput.Clear();
                    sequence += 1;

                    if (sequence == 3)
                    {
                        MessageBox.Show("You Have won the game. Congratulations!");
                        this.Close();
                    }

                    generateEquation();

                }
                else
                {
                    incorrect += 1;
                    lblCorrectIncorrect.Text = "Incorrect!";
                    lblCorrectIncorrect.ForeColor = Color.Red;
                    lblIncorrect.Text = incorrect.ToString();
                    sequence = 0;
                    txtInput.Clear();

                }
            }
            else
            {
                incorrect += 1;
                lblCorrectIncorrect.Text = "Incorrect!";
                lblCorrectIncorrect.ForeColor = Color.Red;
                lblIncorrect.Text = incorrect.ToString();
                sequence = 0;
                txtInput.Clear();
            }


            
        }

        
    }

}
