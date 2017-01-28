using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOptions
{
    public class BooksOptionsClass
    {
        public void BooksOptions() //book menu options
        {
            Console.WriteLine("\nYou have selected Block Books\nHere is a list of our available titles.\n");
            Console.WriteLine("Anna Karenina by Leo Tolstoy\nMadame Bovary by Gustave Flaubert\nWar and Peace by Leo Tolstoy\nThe Great Gatsby by F.Scott Fitzgerald\nLolita by Vladimir Nabokov\nMiddlemarch by George Eliot\nThe Adventures of Huckleberry Finn by Mark Twain\nThe Hobbit by J.R.R. Tolkien\n");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Rent");
            Console.WriteLine("2. Buy");
            Console.WriteLine("3. Go Back");
        }
        public void RentOptions() //rent options menu
        {
            Console.WriteLine("\nYou have selected to Rent a Block Book(s)\nHere is a list of our available titles.\n");
            Console.WriteLine("Anna Karenina by Leo Tolstoy\nMadame Bovary by Gustave Flaubert\nWar and Peace by Leo Tolstoy\nThe Great Gatsby by F.Scott Fitzgerald\nLolita by Vladimir Nabokov\nMiddlemarch by George Eliot\nThe Adventures of Huckleberry Finn by Mark Twain\nThe Hobbit by J.R.R. Tolkien\n");
            Console.WriteLine("Rental costs are .50C/day");
            Console.WriteLine("What book would you like to read?");

        }

        public void BuyOptions() //buy menu options
        {
            Console.WriteLine("\nYou have selected to Buy a Block Book(s)\nHere is a list of our available titles.\n");
            Console.WriteLine("Anna Karenina by Leo Tolstoy $5.00\nMadame Bovary by Gustave Flaubert $15.00\nWar and Peace by Leo Tolstoy $10.00\nThe Great Gatsby by F.Scott Fitzgerald $20.00\nLolita by Vladimir Nabokov $5.00\nMiddlemarch by George Eliot $3.50\nThe Adventures of Huckleberry Finn by Mark Twain $25.00\nThe Hobbit by J.R.R. Tolkien $5.00\n");
            Console.WriteLine("What book would you like to read?");
        }
    }
}
