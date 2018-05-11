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

        public void GetNumPlayers()
        {
            Console.WriteLine("Choose how many players.\n-  1  OR  2  -");
            numOfPlayers = Console.ReadLine();
            AssignPlayers(numOfPlayers);
        }

        public void AssignPlayers(string numOfPlayers)
        {
            if (numOfPlayers == "1")
            {
                player1 =
                object ComputerPlayer player2 = new ComputerPlayer();
            }
            if (numOfPlayers == "2")
            {

            }
            else
            {
                Console.WriteLine("You entered an invalid selection. Please try again.");
                GetNumPlayers();
            }
        }
    }
}
