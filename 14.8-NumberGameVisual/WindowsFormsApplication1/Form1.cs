using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();

        }
        // Instantiate Object
        GuessingGame GuessThatNumber = new GuessingGame();
        
        
        //Load Method
        private void frmGuessNumber_Load(object sender, EventArgs e)
        {
            GuessThatNumber.CreateRandom();
        }


        //Button Click: Guess by user
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string strGuess = txtGuess.Text;
            int GuessProcessValue;
            GuessProcessValue =  GuessThatNumber.GuessProcessor(strGuess);
            
            while(GuessThatNumber.NumGuess != GuessThatNumber.NumRand)
            //Insert Text box guess into Class Guessing Game
           
          
            //while(GuessProcessValue != 100)
            //{
            switch(GuessProcessValue)
            {
                case 1:
                    {
                        lblGuessStatus.Text = "Too High";
                        break;
                    }
                case -1:
                    {
                        lblGuessStatus.Text = "Too Low";
                        break;
                    }
                case 100:
                    {
                        lblGuessStatus.Text = "Correct!";
                        break;
                    }
                case -100:
                    {
                        lblGuessStatus.Text = "Please enter a valid Number within the range";
                        break;
                    }
                case 0:
                    {
                        lblGuessStatus.Text = "Numbers Only Please";
                        break;
                    }
                default :
                    {
                        lblGuessStatus.Text = "RESTART Game";
                        break;
                    }
                    
            }
            txtGuess.Text = "";

            //Color: backColor change Warm Cold
            string backColor;
            backColor = GuessThatNumber.GuessWarmCold();
            if(backColor == "blue")
            {
               // this.BackColor.GetHue;            
            }

            }
            



            //If statement to determine result of the guess
        }

       

        
    }

