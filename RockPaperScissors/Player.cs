using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public int turnNum = 0;
        public int moveValue;
        public int wins = 0;

        public int MakeMove()
        {
            turnNum++;
            return moveValue; 
        }

   
    }
}
