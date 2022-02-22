using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public  class RollTheDice
    {
        public static void RollDice()
        {
            Console.WriteLine("After rolloung the dice, player gets below number:");
            Random random = new Random();
            int num = random.Next(1, 7);
            Console.WriteLine(num);
        }
    }
}
