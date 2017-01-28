using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameOptions
{
    public class VideoGamesOptionsClass
    {
        public void Options() //main menu
        {
            Console.WriteLine("\nYou have selected Block Video Games\nHere is a list of our available titles.\n");
            Console.WriteLine("Super Mario Bros.\nThe Legend of Zelda\nMinecraft\nMs. Pac-Man\nDoom\nThe Legend of Zelda: Ocarina of Time\nSuper Mario 64\nTetris\n");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Rent");
            Console.WriteLine("2. Buy");
            Console.WriteLine("3. Go Back");
        }

        public void RentOptions() //rent
        {
            Console.WriteLine("\nYou have selected to Rent a Block Video Game(s)\nHere is a list of our available titles.\n");
            Console.WriteLine("Super Mario Bros.\nThe Legend of Zelda\nMinecraft\nMs. Pac-Man\nDoom\nThe Legend of Zelda: Ocarina of Time\nSuper Mario 64\nTetris\n");
            Console.WriteLine("Rental costs are $1.50/day");
            Console.WriteLine("What game would you like to play?");

        }

        public void BuyOptions() //buy
        {
            Console.WriteLine("\nYou have selected to Buy a Block Video(s)\nHere is a list of our available titles.\n");
            Console.WriteLine("Super Mario Bros. $10.00\nThe Legend of Zelda $20.00\nMinecraft $21.30\nMs. Pac-Man $5.00\nDoom $60.00\nThe Legend of Zelda: Ocarina of Time $30.00\nSuper Mario 64 $12.00\nTetris $2.50\n");
            Console.WriteLine("What game would you like to play?");
        }
    }
}
