using System;
using System.Collections.Generic;
using System.Text;

namespace EX_8A_Roulette
{
    class ExactBet
    {
        public static int myNumber;
        public static string myColor;
        public static int winnerNumber = GetWinner().Item1;
        public static string winnerColor = Roulette.colors[winnerNumber];

        public static ( int number, string color) GetWinner()
        {
            Roulette rouletteWheel = new Roulette();
            (int number, string color) ball = rouletteWheel.SpinWheel();
            return ball;
        }
       

        public static bool NumberBet()
        {
            
            Console.WriteLine("What number are you betting? (0 - 36, 37 for 00)");
            myNumber = Int32.Parse(Console.ReadLine());

            // set the color for my number   
            myColor = Roulette.colors[myNumber];

            if((myNumber != 0 || myNumber != 37) && myNumber == winnerNumber) //same number       
            {
                Console.WriteLine("Winner!");
                
            }
            if (myNumber == 0 || myNumber == 37 && myNumber == winnerNumber)
            {
                Console.WriteLine("Winner!");
            }

            else
            {
                Console.WriteLine("Better luck next time.");
                return false;
            }

            return true;
        }
        public static bool EvenOrOddBet()
        {
            Console.WriteLine("Are you betting even or odd? (1 - Even, 2 - Odd)");
            int evenOrOdd = Int32.Parse(Console.ReadLine());
            // set the color for the winning number   
            myColor = winnerColor;
            if (evenOrOdd == 1) //Even
            {
                if((winnerNumber != 0 && winnerNumber != 37) && (winnerNumber % 2 == 0)) //even  
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }

            }
            if(evenOrOdd == 2)
            {
                if ((winnerNumber != 0 && winnerNumber != 37) && (winnerNumber % 2 != 0)) //odd
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
            }
            return true;
        }
        public static bool RedOrBlackBet()
        {
            Console.WriteLine("Are you betting red or black? (1 - Red, 2 - Black)");
            int redOrBlack = Int32.Parse(Console.ReadLine());
            if(redOrBlack == 1) //Red
            {
                myColor = "red";
                if (myColor == winnerColor) //red  
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }

            }
            if(redOrBlack == 2)
            {
                myColor = "black";
                if (myColor == winnerColor) //black 
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
            }
            return true;
        }
        public static bool LowOrHighBet()
        {
            Console.WriteLine("Are you betting low or high? (1 - Low, 2 - High)");
            int lowOrHigh = Int32.Parse(Console.ReadLine());
            // set the color for the winning number   
            myColor = winnerColor;
            if (lowOrHigh == 1) //Low
            {
                if(winnerNumber >= 1 && winnerNumber <= 18) //Low (1-18) 
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }

            }
            if (lowOrHigh == 2)//High
            {
                if(winnerNumber >= 19 && winnerNumber <= 36) //High (19-36) 
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
            }
            return true;
        }
        public static bool DozensBet()
        {
            Console.WriteLine("1st, 2nd, or 3rd Dozens? (1 - 1st Dozen, 2 - 2nd Dozen, 3 - 3rd Dozen)");
            int dozens = Int32.Parse(Console.ReadLine());
            // set the color for the winning number   
            myColor = winnerColor;
            if (dozens == 1) //1st dozen (1-12)
            {
                if (winnerNumber >= 1 && winnerNumber <= 12) //(1-12)
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }

            }
            if (dozens == 2)//2nd dozen (13-24)
            {
                if (winnerNumber >= 13 && winnerNumber <= 24) //(13-24) 
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
            }
            if (dozens == 3)//3rd dozen (25-36)
            {
                if (winnerNumber >= 25 && winnerNumber <= 36) //(25-36) 
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
            }
            return true;
        }        
    }
}
