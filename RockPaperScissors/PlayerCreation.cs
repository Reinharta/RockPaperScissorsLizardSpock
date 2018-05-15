using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class PlayerCreation
    {
        public string numOfPlayers;
        public Player player1;
        public Player player2;
        public string p1Name;
        public string p2Name;

        public void GetNumPlayers()
        {
            Console.WriteLine("Choose how many players.\n-  1  OR  2  -");
            numOfPlayers = Console.ReadLine();
            AssignPlayers(numOfPlayers);
        }

        public void AssignPlayers(string numOfPlayers)
        {
            switch (numOfPlayers) {
                case "1":
                        Console.WriteLine("Please enter Player Name.");
                        p1Name = Console.ReadLine();
                        player1 = new HumanPlayer();
                        p2Name = "Computer";
                        player2 = new ComputerPlayer();
                        GamePlay playGame = new GamePlay(player1, p1Name, player2, p2Name);
                        playGame.GetRoundMoves();
                    break;

                case "2":
                        Console.WriteLine("Please enter Player 1 Name.");
                        p1Name = Console.ReadLine();
                        player1 = new HumanPlayer();
                        Console.WriteLine("Please enter Player 2 Name.");
                        p2Name = Console.ReadLine();
                        player2 = new HumanPlayer2();
                        GamePlay playGameTwoPlayer = new GamePlay(player1, p1Name, player2, p2Name);
                        playGameTwoPlayer.GetRoundMoves();
                    break;

                default:
                        Console.WriteLine("You entered an invalid selection. Please try again.");
                        GetNumPlayers();
                        break;

                    }
            
        }

        }
    }

