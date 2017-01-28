using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using VideoGameOptions;

namespace VideoGamesRent
{
    public class VideoGamesRentClass //same notes as the other rent dlls
    {
    }

    public class Rent
    {
        public void RentInput()
        {
            SloganDisplay display = new SloganDisplay();
            display.Display();
            try
            {
                VideoGamesOptionsClass rentOptions = new VideoGamesOptionsClass();
                rentOptions.RentOptions();
                Console.WriteLine("Enter Product Name: ");
                string productName = Console.ReadLine();

                string[] names = new string[8] { "Super Mario Bros.","The Legend of Zelda","Minecraft","Ms. Pac-Man","Doom","The Legend of Zelda: Ocarina of Time","Super Mario 64","Tetris"};
                if (names.Any(productName.Equals))
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
                    SloganDisplay displayError = new SloganDisplay();
                    displayError.Display();
                    Console.WriteLine("Please enter an avalible title\n Press Enter to continue");
                    Console.ReadLine();
                    RentInput();
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
            DateTime returndate = today.AddDays(mynumberdays);
            string productreturndate = returndate.ToString("MM/dd/yyyy");
            return productreturndate;
        }
        public double RentCost(int numberdays)
        {
            double mynumberdays = Convert.ToDouble(numberdays);
            double totalrent = numberdays * 1.50;
            return totalrent;
        }

    }

    public class Display
    {
        public void EndDisplay(string productName, string therentdate, double totalrentcost)
        {
            SloganDisplay dis = new SloganDisplay();
            string finalRentdate = therentdate;
            string finalProductName = productName;
            double finalRentcost = totalrentcost;
            Console.WriteLine("Thank you for renting " + finalProductName + "\n" + "It will need to be return on " + finalRentdate + "\n" + "Total rental cost is " + finalRentcost.ToString("C") + "\n" + "Please press enter to return to the Blocks Video Games Menu");
            Console.ReadLine();

        }
    }
}
