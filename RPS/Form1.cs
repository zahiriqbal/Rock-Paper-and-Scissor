using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        private List<string> RPS = new List<string>();
        private Random randNum = new Random();

        public Form1()
        {

            InitializeComponent();
            RPS.Clear();
            RPS.Add("Rock");
            RPS.Add("Paper");
            RPS.Add("Scissor");
        }


        public string calcWins()
        {

            string message = string.Empty;

            if(player1.SelectedItem == null ) { return message = "Player 1 select your option to play!";}
            if (player2.SelectedItem == null) { return message = "Player 2 select your option to play!"; }

            //Draws
            if (player1.SelectedItem.ToString() == "Rock" && player2.SelectedItem.ToString() == "Rock") { message = "Its a draw!"; }
            if (player1.SelectedItem.ToString() == "Paper" && player2.SelectedItem.ToString() == "Paper") { message = "Its a draw!"; }
            if (player1.SelectedItem.ToString() == "Scissor" && player2.SelectedItem.ToString() == "Scissor") { message = "Its a draw!"; }

            //Player 1
            if (player1.SelectedItem.ToString() == "Rock" && player2.SelectedItem.ToString() == "Scissor") { message = "Player 1 wins!"; }
            if (player1.SelectedItem.ToString() == "Rock" && player2.SelectedItem.ToString() == "Paper") { message = "Player 2 wins!"; }

            if (player1.SelectedItem.ToString() == "Paper" && player2.SelectedItem.ToString() == "Scissor") { message = "Player 2 wins!"; }
            if (player1.SelectedItem.ToString() == "Paper" && player2.SelectedItem.ToString() == "Rock") { message = "Player 1 wins!"; }

            if (player1.SelectedItem.ToString() == "Scissor" && player2.SelectedItem.ToString() == "Rock") { message = "Player 2 wins!"; }
            if (player1.SelectedItem.ToString() == "Scissor" && player2.SelectedItem.ToString() == "Paper") { message = "Player 1 wins!"; }

            //Player 2
            if (player2.SelectedItem.ToString() == "Rock" && player1.SelectedItem.ToString() == "Scissor") { message = "Player 2 wins!"; }
            if (player2.SelectedItem.ToString() == "Rock" && player1.SelectedItem.ToString() == "Paper") { message = "Player 1 wins!"; }

            if (player2.SelectedItem.ToString() == "Paper" && player1.SelectedItem.ToString() == "Scissor") { message = "Player 1 wins!"; }
            if (player2.SelectedItem.ToString() == "Paper" && player1.SelectedItem.ToString() == "Rock") { message = "Player 2 wins!"; }

            if (player2.SelectedItem.ToString() == "Scissor" && player1.SelectedItem.ToString() == "Rock") { message = "Player 1 wins!"; }
            if (player2.SelectedItem.ToString() == "Scissor" && player1.SelectedItem.ToString() == "Paper") { message = "Player 2 wins!"; }

           return message;
        }


        public string compsPlay1()
        {
            int aRandomPos = randNum.Next(RPS.Count);
            string compChoice1 = RPS[aRandomPos];


            player1.SetItemCheckState(aRandomPos, CheckState.Checked);
            Thread.Sleep(1000);
            player1.SelectedItem = compChoice1;

            return compChoice1;
        }


        public string compsPlay2()
        {
            int aRandomPos = randNum.Next(RPS.Count);
            string compChoice2 = RPS[aRandomPos];

            player2.SetItemCheckState(aRandomPos, CheckState.Checked);
            Thread.Sleep(1000);
            player2.SelectedItem = compChoice2;

            return compChoice2;
        }




        public void button1_Click(object sender, EventArgs e)
        {
            bool playa1 = false;
            bool playa2 = false;

            if (checkBox1.Checked == true) { playa1 = true; }
            if (checkBox2.Checked == true) { playa2 = true; }


            if (playa1 == true && playa2 == true) {
                compsPlay1();
                compsPlay2();
                MessageBox.Show(calcWins());
            }
            else if (playa1 == true && playa2 == false) {
                compsPlay1();
                MessageBox.Show(calcWins());
            }
            else if (playa1 == false && playa2 == true) {
                compsPlay2();
                MessageBox.Show(calcWins());
            }
            else { 
                    MessageBox.Show(calcWins());
                 }

            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
            
        }
    }
}