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
       public const int STACKE = 100;
        public const int BET = 1;
        public int stake=STACKE, loosingAmount=STACKE/2, winnigAmount=(STACKE/2)+STACKE;
        //method
        public void winOrLoss()
        {
            //craeting a random value 
            Random random = new Random();
            //taking a random 0 to 2
            int value = random.Next(0, 2);
            if (value == 1)
            {
                //increment + 1
                stake++;
            }
            else
            {
                //decrement -1
                stake--;
            }
        }
        //method for Game
        public int Game()
        {
            //checking in W=hile if stake<winnigAmount && stake > loosingAmount
            while (stake<winnigAmount && stake > loosingAmount)
            {
                // fetch the winorloss method
                winOrLoss();
            }
            //if stake == winningAmount
            if (stake == winnigAmount)
            {
                Console.WriteLine("Win and resign for day");
            }  //if stake == loosingAmount
            if (stake == loosingAmount)
            {
                Console.WriteLine("Loss and resign for day");
            }
            return stake;
        }
    }
}
