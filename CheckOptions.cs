using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class CheckOptions
    {
        public static void CheckPositionOfPlayer()
        {
            int IsLadder = 1, IsSnake = 2, Position = 0;
            // Use of Random function to get one option
            Random rand = new Random();
            int option = rand.Next(3);
            Console.WriteLine("Choosen option is " + option);
            // Use of Random function to roll the dice
            Random rand2 = new Random();
            int DiceNum = rand2.Next(1,7);
            Console.WriteLine("The number got on Dice is " + DiceNum);
         
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
                    Console.WriteLine("Player stays at the same position");
                    break;

            }
            if (Position < 0)
                Position = 0;

            Console.WriteLine("New position of player after throwing dice is " + Position);
        }
    }
}
