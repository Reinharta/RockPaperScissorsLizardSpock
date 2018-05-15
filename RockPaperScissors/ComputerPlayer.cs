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
        //public int rndmIndex;

        public override void DisplayMoves(string playerName)
        {
            List<string> moveList = new List<string>();
            moveList.Add("Rock");
            moveList.Add("Paper");
            moveList.Add("Scissors");
            moveList.Add("Spock");
            moveList.Add("Lizard");
            GetMove(moveList);
        }
        public override void GetMove(List <string> moveList)
        {
            moveValue = random.Next(0, 5);
            move = Convert.ToString(moveList.ElementAt(moveValue));
        }
        
        
    }
}
