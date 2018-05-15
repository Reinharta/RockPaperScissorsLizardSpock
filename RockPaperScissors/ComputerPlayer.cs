using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ComputerPlayer : Player
    {
        public Random random = new Random();

        public override void DisplayMoves(string playerName)
        {

        }
        public override void GetMove(List <string> moveList)
        {
            move = Convert.ToString(random.Next(1, 6));
            moveValue = moveList.IndexOf(move);
        }
    }
}
