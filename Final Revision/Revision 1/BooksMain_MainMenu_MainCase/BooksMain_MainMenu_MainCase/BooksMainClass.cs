using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using BooksOptions;
using BooksRent;
using BooksBuy;

namespace BooksMain_MainMenu_MainCase
{
    public class BooksMainClass
    {
        public void Books()
        {
            int userInput = 0;
            while (userInput != 3)
            {
                SloganDisplay errorSlogan = new SloganDisplay(); //create errorSlogan
                errorSlogan.Display();                          //run errorSlogan, this is here for when errors occur
                BooksMainMenuClass BookMenuInstance = new BooksMainMenuClass(); //create NewBookMenu
                userInput = BookMenuInstance.BooksMainMenu();            //run BooksMainMenuClass, this is the main menu
                BooksCaseClass BookCaseInstance = new BooksCaseClass();// create bookscase class
                BookCaseInstance.BooksCase(userInput);                      //run bookscase class with userinput as a variable input
            }
        }
    }

    public class BooksMainMenuClass
    {
        public int BooksMainMenu()
        {
            BooksOptionsClass BooksOptionsInstance = new BooksOptionsClass(); //books options
            BooksOptionsInstance.BooksOptions();
            int result = 0; //starting vaule of result
            try
            {
                result = int.Parse(Console.ReadLine()); //userinput
                return result;
            }
            catch (Exception myerror)
            {
                Console.WriteLine(myerror.Message);

            }
            return result;
        }

    }

    public class BooksCaseClass
    {
        public void BooksCase(int results)
        {
            int myInput;
            myInput = results;
            switch (myInput)
            {
                case 0:
                    SloganDisplay zeroSlogan = new SloganDisplay(); //slogan
                    zeroSlogan.Display();
                    break;
                case 1: //Rent
                    SloganDisplay rentSlogan = new SloganDisplay(); //slogan
                    rentSlogan.Display();
                    RentBooks rent = new RentBooks();
                    rent.RentInput(); //run rentinput
                    break;

                case 2: //Buy
                    SloganDisplay buySlogan = new SloganDisplay(); //slogan
                    buySlogan.Display();
                    BooksBuyClass buy = new BooksBuyClass();
                    buy.BuyInput(); //run buy input
                    break;

                case 3://goes back one screen

                    break;


            }
        }
    }
}
