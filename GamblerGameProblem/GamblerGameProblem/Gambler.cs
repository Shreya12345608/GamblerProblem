﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerGameProblem
{
    //class  Gambler

    class Gambler
    {
        //Instance Variable
        public int STACKE = 100;
        public int BET = 1;
        public void winOrloss()
        {
            //Check wheather gambler win or loss
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 1)
                Console.WriteLine("Gambler won");
            else
                Console.WriteLine("gambler loss");
        }
    }
}

