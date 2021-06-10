using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerGameProblem
{

    //Main Program
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to gambling solution");
            Gambler gambler  = new Gambler();
            gambler.winOrLoss();
           
        }
    }
}
}