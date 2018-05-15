using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string move;
        public int turnNum = 0;
        public int moveValue;
        public int wins = 0;

        public virtual void DisplayMoves()
        {
            List<string> moveList = new List<string>();
            moveList.Add("Rock");
            moveList.Add("Paper");
            moveList.Add("Scissors");
            moveList.Add("Spock");
            moveList.Add("Lizard");
            Console.WriteLine("Please choose your move from the list below.");
            moveList.ForEach(Console.WriteLine);
            GetMove(moveList);
        }

        public virtual void GetMove(List<string> moveList)
        {
            move = Console.ReadLine();
            moveValue = moveList.IndexOf(move);
            MakeMove(move, moveValue);
        }
        

        public int MakeMove(string move, int moveValue)
        {
            turnNum++;

            return moveValue; 
        }

   
    }
}
