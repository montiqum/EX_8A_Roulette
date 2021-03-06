using System;

namespace EX_8A_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int winner_Number = ExactBet.winnerNumber;
            string winner_Color = ExactBet.winnerColor;
            Roulette rouletteWheel = new Roulette();
            rouletteWheel.PrintBetTable();
            UserInput.GetTheBetType();
    
            if (winner_Number == 37)
            {
                Console.WriteLine($"\nThe winning number and color is: 00, {winner_Color}");               
            }
            else
            {
                Console.WriteLine($"\nThe winning number and color is: {winner_Number}, {winner_Color}");            
            }
            DisplayResults.Display_Results();

        }
    }
}
           




