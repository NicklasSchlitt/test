using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        string compChoice, myChoice, winner;
        int number = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            getCompChoice();
        }
        private void getCompChoice()
        {
            int number = rand.Next(1, 3);
            lblOutput.Text = "";
            switch (number)
            {
                case 1:
                    compChoice = "Rock";
                    break;
                case 2:
                    compChoice = "Paper";
                    break;
                case 3:
                    compChoice = "Scissors";
                    break;
            }
        }
        private void showWinner()
        {
            if(myChoice == "Rock" && compChoice == "Scissors")
            {
                lblOutput.Text = "Nice job you beat a randomized Computer.\nThe Computer chose " + "Scissors";
            }
            if(myChoice == "Scissors" && compChoice == "Rock")
            {
                lblOutput.Text = "Nice try.\nThe computer beat you by picking " + "Rock";
            }
            if (myChoice == "Paper" && compChoice == "Rock")
            {
                lblOutput.Text = "Nice job you beat a randomized Computer.\nThe Computer chose " + "Rock";
            }
            if (myChoice == "Rock" && compChoice == "Paper")
            {
                lblOutput.Text = "Nice try.\nThe computer beat you by picking " + "Paper";
            }
            if (myChoice == "Scissors" && compChoice == "Paper")
            {
                lblOutput.Text = "Nice job you beat a randomized Computer.\nThe Computer chose " + "Paper";
            }
            if (myChoice == "Paper" && compChoice == "Scissors")
            {
                lblOutput.Text = "Nice try.\nThe computer beat you by picking " + "Scissors";
            }
            if (myChoice == compChoice)
            {
                lblOutput.Text = "You and the Computer chose the Same thing.\nWhat are the chances of that";
            }
        }
        private void picRock_Click(object sender, EventArgs e)
        {
            myChoice = "Rock";
            showWinner();
        }
        private void picPaper_Click(object sender, EventArgs e)
        {
            myChoice = "Paper";
            showWinner();
        }
        private void picScissors_Click(object sender, EventArgs e)
        {
            myChoice = "Scissors";
            showWinner();
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            getCompChoice();
        }
    }
}
