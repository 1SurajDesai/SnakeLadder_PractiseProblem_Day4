using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class WinningPosition100
    {
        public static void RepeatTillPlayerReaches100()
        {
            int IsLadder = 1, IsSnake = 2, Position = 0;

            while (Position != 100)
            {
                // Use of Random function to get one option
                Random rand = new Random();
                int option = rand.Next(3);
                // Use of Random function to roll the dice
                Random rand2 = new Random();
                int DiceNum = rand2.Next(1, 7);

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
            }
            Console.WriteLine("Player has reached a winning Position of " + Position);

        }
    }
}
