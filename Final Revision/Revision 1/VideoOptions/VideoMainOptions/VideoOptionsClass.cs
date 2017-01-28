using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMainOptions
{
    public class VideoOptionsClass
    {
        public void Options() //main menu 
        {
            Console.WriteLine("\nYou have selected Block Videos\nHere is a list of our available titles.\n");
            Console.WriteLine("The Shawshank Redemption (1994)\nThe Godfather(1972)\nThe Godfather: Part II(1974)\nThe Dark Knight(2008)\nSchindler's List (1993)\n12 Angry Men(1957)\nPulp Fiction(1994)\nThe Lord of the Rings: The Return of the King(2003)\n");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Rent");
            Console.WriteLine("2. Buy");
            Console.WriteLine("3. Go Back");
        }

        public void RentOptions() //rent
        {
            Console.WriteLine("\nYou have selected to Rent a Block Video(s)\nHere is a list of our available titles.\n");
            Console.WriteLine("The Shawshank Redemption (1994)\nThe Godfather(1972)\nThe Godfather: Part II(1974)\nThe Dark Knight(2008)\nSchindler's List (1993)\n12 Angry Men(1957)\nPulp Fiction(1994)\nThe Lord of the Rings: The Return of the King(2003)\n");
            Console.WriteLine("Rental costs are .99C/day");
            Console.WriteLine("What movie would you like to see?");

        }

        public void BuyOptions() //buy
        {
            Console.WriteLine("\nYou have selected to Buy a Block Video(s)\nHere is a list of our available titles.\n");
            Console.WriteLine("The Shawshank Redemption (1994) $5.00\nThe Godfather(1972) $15.00\nThe Godfather: Part II(1974) $10.00\nThe Dark Knight(2008) $20.00\nSchindler's List (1993) $5.00\n12 Angry Men(1957) $3.50\nPulp Fiction(1994) $25.00\nThe Lord of the Rings: The Return of the King(2003) $5.00\n");
            Console.WriteLine("What movie would you like to see?");
        }
    }
}
