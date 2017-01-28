using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using BooksOptions;

namespace BooksBuy
{
    public class BooksBuyClass
    {
        public void BuyInput()
        {
            SloganDisplay buySlogan = new SloganDisplay(); //slogan
            buySlogan.Display(); //display slogan
            try
            {
                BooksOptionsClass buyOptions = new BooksOptionsClass(); //book options class called
                buyOptions.BuyOptions();//use the buy options class inside book options
                Console.WriteLine("Enter Product Name:                        (Exclude author when entering product name)"); //printed to screen asking for userinput(string)
                string productName = Console.ReadLine();// userinput(string) called productName
                // !Never used! double[] prices = new double[8] { 5.00, 15.00, 10.00, 20.00, 5.00, 3.50, 25.00, 5.00 };
                string[] names = new string[8] { "Anna Karenina", "Madame Bovary", "War and Peace", "The Great Gatsby", "Lolita", "Middlemarch", "The Adventures of Huckleberry Finn", "The Hobbit" };
                //above is an array that holds all titles we offer(8)
                if (names.Any(productName.Equals))//check that productName equals a value in the array(any value)
                {
                    //if productName equals a value in the array, we then check to see what productName was entered to find the cost of the item.
                    if (productName.Equals("Anna Karenina"))
                    {
                        double bookscost = 5.00; //cost of the item
                        BooksCostCal mybookscost = new BooksCostCal(); //call the bookcostcal class
                        double totalcost = mybookscost.CostCal(bookscost);//send bookcost into the bookcostcal class then but the value into totalcost
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();//call the bookbuydisplay
                        newDisplay.BooksDisplay(productName, totalcost);//send the productName and totalcost to the display class
                    }
                    if (productName.Equals("Madame Bovary"))
                    {
                        double bookscost = 15.00;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);
                    }
                    if (productName.Equals("War and Peace"))
                    {
                        double bookscost = 10.00;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Great Gatsby"))
                    {
                        double bookscost = 20.00;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Lolita"))
                    {
                        double bookscost = 5.00;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Middlemarch"))
                    {
                        double bookscost = 3.50;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Adventures of Huckleberry Finn"))
                    {
                        double bookscost = 25.00;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Hobbit"))
                    {
                        double bookscost = 5.00;
                        BooksCostCal mybookscost = new BooksCostCal();
                        double totalcost = mybookscost.CostCal(bookscost);
                        BooksBuyDisplay newDisplay = new BooksBuyDisplay();
                        newDisplay.BooksDisplay(productName, totalcost);

                    }


                }
                else //runs if the productName entered isnt in the array but doesnt throw and error
                {
                    SloganDisplay displayError = new SloganDisplay(); //solgan
                    displayError.Display(); //display the slogan
                    Console.WriteLine("Please enter an avalible title\n Press Enter to continue"); //write and wait for user key strike
                    Console.ReadLine();
                    BuyInput(); //run the method again
                }

            }
            catch (Exception myerror) //error catch
            {
                Console.WriteLine(myerror.Message);
            }
        }
    }

    public class BooksCostCal
    {
        public double CostCal(double booksprice)
        {
            double mybooksprice = booksprice;
            double totalcost = (mybooksprice * .06) + mybooksprice;
            return totalcost;
        }
    }

    public class BooksBuyDisplay
    {
        public void BooksDisplay(string productName, double totalcost)
        {
            string finalProductName = productName;
            double finalRentcost = totalcost;
            Console.WriteLine("Thank you for buying " + finalProductName + "\n" + "The total cost is " + finalRentcost.ToString("C") + " (includes tax)" + "\n" + "Please press enter to return to the Blocks Books Menu");
            Console.ReadLine();
        }
    }

}
