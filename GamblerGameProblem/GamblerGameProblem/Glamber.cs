using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerGameProblem
{
    class Gambler
    {
        //Instance Variable
        const int STACKE = 100;
        const int BET = 1;

        //method
        public void winOrLoss()
        {
            //craeting a random value 
            Random random = new Random();
            //taking a random 0 to 2
            int value = random.Next(0, 2);
            //if value == 1  gambler won
            if (value == 1)
                Console.WriteLine("gambler won");
            //else loss 
            else
                Console.WriteLine("gambler loss");
        }
    }
}
