using System;
using System.Collections.Generic;
using System.Text;

namespace EX_8A_Roulette
{
    class UserInput
    {
        public static void GetTheBetType()
        {
            Console.WriteLine("What kind of bet? ");
            Console.WriteLine("0 - Numbers, 1 - Even/Odd, 2 - Red/Black, 3 - Low/High, 4 - Dozens");
            Console.WriteLine("5 - Columns, 6 - Street, 7 - 6 Numbers, 8 - Split, 9 - Corner");
            int typeOfBet = Int32.Parse(Console.ReadLine());
            switch (typeOfBet)
            {
                case 0:
                    Console.WriteLine("Number Bet");
                    ExactBet.NumberBet();
                    break;
                case 1:
                    Console.WriteLine("Even/Odds");
                    ExactBet.EvenOrOddBet();
                    break;
                case 2:
                    Console.WriteLine("Red/Black");
                    ExactBet.RedOrBlackBet();
                    break;
                case 3:
                    Console.WriteLine("Low/High");
                    ExactBet.LowOrHighBet();
                    break;
                case 4:
                    Console.WriteLine("Dozens");
                    ExactBet.DozensBet();
                    break;
                case 5:
                    Console.WriteLine("Columns");
                    ExactBet2.ColumnsBet();
                    break;
                case 6:
                    Console.WriteLine("Street");
                    ExactBet2.StreetBet();
                    break;
                case 7:
                    Console.WriteLine("6 Numbers");
                    ExactBet2.Numbers6Bet();
                    break;
                case 8:
                    Console.WriteLine("Split");
                    ExactBet2.SplitBet();
                    break;
                case 9:
                    Console.WriteLine("Corner");
                    ExactBet2.CornerBet();
                    break;
                default:
                    try
                    {
                        Console.WriteLine("Invalid input. Try Again.");
                        typeOfBet = Int32.Parse(Console.ReadLine());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }

                    break;
            }
            

        }
    }
}
