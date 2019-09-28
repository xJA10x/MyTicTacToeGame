
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {


        bool theTurn = true;
        int turnTimes = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("By Pablo", "Tic Tac Toe Game about");


        }
 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Application.Exit();

        }

        private void button_click(object sender, EventArgs e)
        {

            
            Button b = (Button)sender;

           
            if (theTurn)
            {
               
                b.Text = "X";

            } else
            {
               
                b.Text = "O";

            }


            theTurn = !theTurn;

            
            b.Enabled = false;

            
            turnTimes++;

            
            ItWon();

        }

        
        private void ItWon()
        {
            
            bool isThereWinner = false;


      
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {

                // If there is a winner,
                // Stores true in the variable isThereWinner.
                isThereWinner = true;

            }
            
           else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                
                isThereWinner = true;

            }

            
            else  if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                
                isThereWinner = true;

            }

           
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                
                isThereWinner = true;

            }

            
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                
                isThereWinner = true;

            }
            
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {

               
                isThereWinner = true;

            }
            
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                
                isThereWinner = true;

            }
            
            else if ((A2.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {

                 
                isThereWinner = true;

            }

            
            if (isThereWinner)
            {
                
                HideButtons();

                
                String winner = "";

                
                if (theTurn)
                {

                    winner = "O";

                } else
                {

                    winner = "X";

                }

                
                MessageBox.Show(winner + " Wins!", ":)");


            } else
            {
                if(turnTimes == 9)
                {

                    MessageBox.Show("Draw!", "Next time!!!");

                }

            }

        }
        
        private void HideButtons()
        {
        
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
        
                    b.Enabled = false;

                }

            } catch
            {


            }

        }
        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            theTurn = true;
            turnTimes = 0;
            
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }

            }
            catch
            {


            }


        }
    }
}
