using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class GamePlay
    {
        public Player playerOne;
        public Player playerTwo;
        public string pOneName;
        public string pTwoName;
        public int pOneMoveVal;
        public int pTwoMoveVal;
        //public string pOneMove;
        //public string pTwoMove;
        public int detWinner;
        public Player roundWinner;
        public string roundWinnerName;
        public int roundCount = 0;

        public GamePlay(Player player1, string p1Name, Player player2, string p2Name)
        {
            playerOne = player1;
            playerTwo = player2;
            pOneName = p1Name;
            pTwoName = p2Name;
        }
        
        public void GetRoundMoves()
        {
            playerOne.DisplayMoves();
            pOneMoveVal = playerOne.moveValue;
            playerTwo.DisplayMoves();
            pTwoMoveVal = playerTwo.moveValue;
            AssessMoves();
        }


        public void AssessMoves()
        {
            detWinner = (5 + pOneMoveVal - pTwoMoveVal) % 5;
            switch (detWinner)
            {
                case 1:
                    roundWinner = playerOne;
                    roundWinnerName = pOneName;
                    break;
                case 2:
                    roundWinner = playerTwo;
                    roundWinnerName = pTwoName;
                    break;
                case 3:
                    roundWinner = playerOne;
                    roundWinnerName = pOneName;
                    break;
                case 4:
                    roundWinner = playerTwo;
                    roundWinnerName = pTwoName;
                    break;
                case 0:
                    roundWinner = null;
                    break;
                default:
                    Console.WriteLine("\nSomething went wrong. Please exit and restart.\n");
                    break;

            }
            roundCount++;
            if (roundWinner != null)
            {
                roundWinner.wins++;
                DisplayWinner();
            }
            if (roundWinner == null)
            {
                Console.WriteLine("\nIt's a tie!");
                AssessRounds();
            }

        }

        public void DisplayWinner()
        {
            Console.WriteLine("\n"+roundWinnerName + " won this round!");
            AssessRounds();

        }

        public void AssessRounds()
        {
            if(roundCount == 3)
            {
                FinalWin();
            }
            if(roundCount < 3)
            {
                GetRoundMoves();
            }
        }

        public void FinalWin()
        {
            if(playerOne.wins > playerTwo.wins)
            {
                Console.WriteLine("\n" + pOneName + " wins best out of three! Congratulations, " + pOneName+ "!");
            }
            if(playerOne.wins < playerTwo.wins)
            {
                Console.WriteLine("\n" + pTwoName + " wins best out of three! Congratulations, " + pTwoName+"!");
            }
        }

    }
}
