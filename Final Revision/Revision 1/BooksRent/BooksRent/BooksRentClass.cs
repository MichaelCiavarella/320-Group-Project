﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using BooksOptions;

namespace BooksRent
{
    public class BooksRentClass
    {
    }

    public class RentBooks
    {
        public void RentInput()
        {
            SloganDisplay display = new SloganDisplay(); //slogan
            display.Display();
            try
            {
                BooksOptionsClass rentOptions = new BooksOptionsClass(); //books options, rent options
                rentOptions.RentOptions();
                Console.WriteLine("Enter Product Name:                          (Exclude author when entering product name)");
                string productName = Console.ReadLine(); //get user input and call it productName

                string[] names = new string[8] { "Anna Karenina", "Madame Bovary", "War and Peace", "The Great Gatsby", "Lolita", "Middlemarch", "The Adventures of Huckleberry Finn","The Hobbit"};
                if (names.Any(productName.Equals)) //make sure productName = names, if not go to else
                {
                    Console.WriteLine("How many days would you like to rent this?");
                    int rentdays = Convert.ToInt16(Console.ReadLine());
                    ReturnDate returndate = new ReturnDate();
                    string thereturndate = returndate.ReturnDateCal(rentdays);
                    double totalrentcost = returndate.RentCost(rentdays);
                    Display newDisplay = new Display();
                    newDisplay.EndDisplay(productName, thereturndate, totalrentcost);
                }
                else
                {
                    SloganDisplay displayError = new SloganDisplay(); //displays slogan
                    displayError.Display();
                    Console.WriteLine("Please enter an avalible title\n Press enter to continue");
                    Console.ReadLine();
                    RentInput(); //return to rentinput, have user try again
                }

            }
            catch (Exception myerror)
            {

                Console.WriteLine(myerror.Message);
            }
        }

    }

    public class ReturnDate
    {
        public string ReturnDateCal(int numberdays)
        {
            int mynumberdays = numberdays;
            DateTime today = DateTime.Now;
            DateTime returndate = today.AddDays(mynumberdays); //adds the number of days the user entered to the current date
            string productreturndate = returndate.ToString("MM/dd/yyyy"); //returns the date in the format of mm/dd/yyyy
            return productreturndate;
        }
        public double RentCost(int numberdays)
        {
            double mynumberdays = Convert.ToDouble(numberdays); //number of days times the cost of renting 
            double totalrent = numberdays * .50;
            return totalrent;
        }

    }

    public class Display
    {
        public void EndDisplay(string productName, string therentdate, double totalrentcost)//display the return date, productName and cost of the item
        {
            SloganDisplay dis = new SloganDisplay();
            string finalRentdate = therentdate;
            string finalProductName = productName;
            double finalRentcost = totalrentcost;
            Console.WriteLine("Thank you for renting " + finalProductName + "\n" + "It will need to be return on " + finalRentdate + "\n" + "Total rental cost is " + finalRentcost.ToString("C") + "\n" + "Please press enter to return to the Blocks Books Menu");
            Console.ReadLine();

        }
    }

}
