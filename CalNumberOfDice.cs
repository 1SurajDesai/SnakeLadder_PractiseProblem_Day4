using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class CalNumberOfDice
    {
        public static void CalNoOfDiceThrownToWin()
        {
            int IsLadder = 1, IsSnake = 2, Position = 0, Flag = 0;

            while (Position != 100)
            {
                // Use of Random function to get one option
                Random rand = new Random();
                int option = rand.Next(3);
                // Use of Random function to roll the dice
                Random rand2 = new Random();
                int DiceNum = rand2.Next(1, 7);
                Flag++;

                switch (option)
                {
                    case 1:
                        Position += DiceNum;
                        break;
                    case 2:
                        Position -= DiceNum;
                        break;
                    default:
                        Position = Position;
                        break;

                }
                if (Position < 0)
                    Position = 0;
                if (Position > 100)
                    Position -= DiceNum;
                Console.WriteLine("Position of Player after throwing dice " + Flag + "times is " + Position);

            }
            Console.WriteLine("Number of times Dice was played to win the game is " + Flag);
        }
    }
}
