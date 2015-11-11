using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame;

namespace GuessNumberGame
{
    class GuessingGame
    {
        
        public double NumGuess;
        public double NumLastGuess;
        public int NumRand;

        public void CreateRandom()
        {
            Random newRand = new Random();
            
            NumRand = newRand.Next(1, 1000);

            

        }
        
       
       
        

        public int GuessProcessor(string userGuess)
        {
            try
            {
                NumGuess = double.Parse(userGuess);
                

                 if(NumGuess > NumRand && NumGuess < 1000)
            {
                //higher than the Random, return a positive value = 1
                return 1;
                
                
            }
            else if (NumGuess < NumRand && NumGuess > 0)
            {
                 //Lower than Random
                return -1;
                
            }
            else if (NumGuess == NumRand)
            {
                //Answer Correct
                return 100;
                
            }
            else
            {
                //Out Of Range
                return -100;
                
            }

            }
            catch
            {
                //Invalid Input
                return 0;
            }

            
        }

        
        //Warmer & Colder based on previous guess
        public string GuessWarmCold()
        {
            if (Math.Abs(NumRand - NumGuess)> Math.Abs(NumRand - NumLastGuess))
            {
                //Turn backColor BLUE
                return "blue";
                
            }
        
         if (Math.Abs(NumRand - NumGuess) < Math.Abs(NumRand - NumLastGuess))
            {
                // Turn backcolor to RED
                return "red";
            }
         else
         {
             return "default";
         }
         NumLastGuess = NumGuess;


        }

        
    }
}
