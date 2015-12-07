using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Grade: 8.5
//Observations:
//The program should allow for a range between 1-1000, yours allows only 1-999 because it is checking for < 1000 instead of <= 1000
//The program should indicate colder or warmer based on getting further away or closer to the number not higher or lower (this was a common mistake, I am not deducting points for it).
//The textbox should be disabled when the user guesses correctly
namespace GuessNumberGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGuessNumber());

             GuessingGame GuessThatNumber = new GuessingGame();

            
        }
    }
}
