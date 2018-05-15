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
        public Player roundLoser;
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
            playerOne.DisplayMoves(pOneName);
            pOneMoveVal = playerOne.moveValue;
            playerTwo.DisplayMoves(pTwoName);
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
                    roundLoser = playerTwo;
                    break;
                case 2:
                    roundWinner = playerTwo;
                    roundWinnerName = pTwoName;
                    roundLoser = playerOne;
                    break;
                case 3:
                    roundWinner = playerOne;
                    roundWinnerName = pOneName;
                    roundLoser = playerTwo;
                    break;
                case 4:
                    roundWinner = playerTwo;
                    roundWinnerName = pTwoName;
                    roundLoser = playerOne;
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
                DisplayRoundOutcome();
            }
            if (roundWinner == null)
            {
                Console.WriteLine("\nIt's a tie!");
                AssessRounds();
            }

        }

        public void DisplayRoundOutcome()
        {
            if (roundWinner.move == "Rock" && roundLoser.move == "Scissors")
            {
                Console.WriteLine("\nRock crushes Scissors...");
                DisplayWinner();
            }
            if (roundWinner.move == "Scissors" && roundLoser.move == "Paper")
            {
                Console.WriteLine("\nScissors cuts Paper...");
                DisplayWinner();
            }
            if (roundWinner.move == "Paper" && roundLoser.move == "Rock")
            {
                Console.WriteLine("\nPaper covers Rock...");
                DisplayWinner();
            }
            if (roundWinner.move == "Rock" && roundLoser.move == "Lizard")
            {
                Console.WriteLine("\nRock crushes Lizard...");
                DisplayWinner();
            }
            if (roundWinner.move == "Lizard" && roundLoser.move == "Spock")
            {
                Console.WriteLine("\nLizard poisons Spock...");
                DisplayWinner();
            }
            if (roundWinner.move == "Spock" && roundLoser.move == "Scissors")
            {
                Console.WriteLine("\nSpock smashes Scissors...");
                DisplayWinner();
            }
            if (roundWinner.move == "Scissors" && roundLoser.move == "Lizard")
            {
                Console.WriteLine("\nScissors decapitates Lizard...");
                DisplayWinner();
            }
            if (roundWinner.move == "Lizard" && roundLoser.move == "Paper")
            {
                Console.WriteLine("\nLizard eats Paper...");
                DisplayWinner();
            }
            if (roundWinner.move == "Paper" && roundLoser.move == "Spock")
            {
                Console.WriteLine("\nPaper disproves Spock...");
                DisplayWinner();
            }
            if (roundWinner.move == "Spock" && roundLoser.move == "Rock")
            {
                Console.WriteLine("\nSpock vaporizes Rock...");
                DisplayWinner();
            }
            //else
            //{
            //    Console.WriteLine("Broken shit");
            //}
        }
    


        public void DisplayWinner()
        {
            Console.WriteLine("\n" + roundWinnerName + " won this round!");
            AssessRounds();

        }

        public void AssessRounds()
        {
            if (roundCount == 3)
            {
                FinalWin();
            }
            if (roundCount < 3)
            {
                GetRoundMoves();
            }
        }

        public void FinalWin()
        {
            if (playerOne.wins > playerTwo.wins)
            {
                Console.WriteLine("\n" + pOneName + " wins best out of three! Congratulations, " + pOneName + "!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            if (playerOne.wins < playerTwo.wins)
            {
                Console.WriteLine("\n" + pTwoName + " wins best out of three! Congratulations, " + pTwoName + "!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            
        }

    }
}

