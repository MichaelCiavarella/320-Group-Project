using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using VideoGameOptions;

namespace VideoGameBuy
{
    public class VideoGamesBuyClass //same notes as the other 2 buy dlls
    {
        public void BuyInput()
        {
            SloganDisplay buySlogan = new SloganDisplay();
            buySlogan.Display();
            try
            {
                VideoGamesOptionsClass buyOptions = new VideoGamesOptionsClass();
                buyOptions.BuyOptions();
                Console.WriteLine("Enter Product Name: ");
                string productName = Console.ReadLine();
                //double[] prices = new double[8] { 10.00, 20.00, 21.30, 5.00, 60.00, 30.00, 12.00, 2.50 };
                string[] names = new string[8] { "Super Mario Bros", "The Legend of Zelda", "Minecraft", "Ms. Pac-Man", "Doom", "The Legend of Zelda: Ocarina of Time", "Super Mario 64", "Tetris" };
                if (names.Any(productName.Equals))
                {
                    if (productName.Equals("Super Mario Bros"))
                    {
                        double videogamecost = 10.00;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Legend of Zelda"))
                    {
                        double videogamecost = 20.00;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Minecraft"))
                    {
                        double videogamecost = 21.30;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Ms. Pac-Man"))
                    {
                        double videogamecost = 5.00;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Doom"))
                    {
                        double videogamecost = 60.00;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Legend of Zelda: Ocarina of Time"))
                    {
                        double videogamecost = 30.00;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Super Mario 64"))
                    {
                        double videogamecost = 12.00;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Tetris"))
                    {
                        double videogamecost = 2.50;
                        VideoGamesCostCal myvideogamecost = new VideoGamesCostCal();
                        double totalcost = myvideogamecost.CostCal(videogamecost);
                        VideoGamesDisplay newDisplay = new VideoGamesDisplay();
                        newDisplay.VideoGameDisplay(productName, totalcost);

                    }


                }
                else
                {
                    SloganDisplay displayError = new SloganDisplay();
                    displayError.Display();
                    Console.WriteLine("Please enter an avalible title\n Press Enter to continue");
                    Console.ReadLine();
                    BuyInput();
                }

            }
            catch (Exception myerror)
            {
                Console.WriteLine(myerror.Message);
            }
        }
    }

    public class VideoGamesCostCal
    {
        public double CostCal(double videoprice)
        {
            double myvideoprice = videoprice;
            double totalcost = (myvideoprice * .06) + myvideoprice;
            return totalcost;
        }
    }

    public class VideoGamesDisplay
    {
        public void VideoGameDisplay(string productName, double totalcost)
        {
            string finalProductName = productName;
            double finalRentcost = totalcost;
            Console.WriteLine("Thank you for buying " + finalProductName + "\n" + "The total cost is " + finalRentcost.ToString("C") + " (includes tax)" + "\n" + "Please press enter to return to the Block Video Games Menu");
            Console.ReadLine();
        }
    }
}
