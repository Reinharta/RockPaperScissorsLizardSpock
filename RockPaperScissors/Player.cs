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
            Console.WriteLine("\nPlease choose your move from the list below.\n");
            moveList.ForEach(Console.WriteLine);
            GetMove(moveList);
        }

        public virtual void GetMove(List<string> moveList)
        {
            move = (Console.ReadLine().ToLower());
            move = UpperFirstLetter(move);
            moveValue = moveList.IndexOf(move);
            ValidateMove(move, moveList);
        }

        private void ValidateMove(string move, List<string> moveList)
        {
            if (moveList.Contains(move))
            {
                MakeMove(move, moveValue);
            }
            else
            {
                Console.WriteLine("\nYou have entered an invalid selection. Please try again.\n");
                DisplayMoves();
            }
        }

        public virtual string UpperFirstLetter(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public int MakeMove(string move, int moveValue)
        {
            turnNum++;

            return moveValue; 
        }

   
    }
}
