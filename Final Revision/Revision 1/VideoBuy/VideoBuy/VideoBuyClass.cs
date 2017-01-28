using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using MainMenu_MainCase;
using VideoMainOptions;

namespace VideoBuy
{

    public class VideoBuyClass
    {
        public void BuyInput()
        {
            SloganDisplay buySlogan = new SloganDisplay(); //slogan
            buySlogan.Display(); //display slogan
            try
            {
                VideoOptionsClass buyOptions = new VideoOptionsClass(); //video options class called
                buyOptions.BuyOptions(); //use the buy options class inside video options
                Console.WriteLine("Enter Product Name:                                    (Exclude date when entering product name)"); //printed to screen asking for userinput(string)
                string productName = Console.ReadLine(); // userinput(string) called productName
                // !Not used! double[] prices = new double[8] { 5.00, 15.00,10.00, 20.00, 5.00, 3.50, 25.00, 5.00};
                string[] names = new string[8] { "The Shawshank Redemption", "The Godfather", "The Godfather: Part II", "The Dark Knight", "Schindler's List", "12 Angry Men", "Pulp Fiction", "The Lord of the Rings: The Return of the King" };
                //above is an array that holds all titles we offer(8)
                if (names.Any(productName.Equals)) //check that productName equals a value in the array(any value)
                {
                    //if productName equals a value in the array, we then check to see what productName was entered to find the cost of the item.
                    if (productName.Equals("The Shawshank Redemption"))
                    {
                        double videocost = 5.00; //cost of the item
                        VideoCostCal myvideocost = new VideoCostCal(); //call the videocostcal class
                        double totalcost = myvideocost.CostCal(videocost); //send videocost into the videocostcal class then but the value into totalcost
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay(); //call the videobuydisplay
                        newDisplay.VideoDisplay(productName, totalcost); //send the productName and totalcost to the display class
                    }
                    if (productName.Equals("The Godfather"))
                    {
                        double videocost = 15.00;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Godfather: Part II"))
                    {
                        double videocost = 10.00;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Dark Knight"))
                    {
                        double videocost = 20.00;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Schindler's List"))
                    {
                        double videocost = 5.00;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                    }
                    if (productName.Equals("12 Angry Men"))
                    {
                        double videocost = 3.50;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                    }
                    if (productName.Equals("Pulp Fiction"))
                    {
                        double videocost = 25.00;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                    }
                    if (productName.Equals("The Lord of the Rings: The Return of the King"))
                    {
                        double videocost = 5.00;
                        VideoCostCal myvideocost = new VideoCostCal();
                        double totalcost = myvideocost.CostCal(videocost);
                        VideoBuyDisplay newDisplay = new VideoBuyDisplay();
                        newDisplay.VideoDisplay(productName, totalcost);
                        
                    }


                }
                else //runs if the productName entered isnt in the array but doesnt throw and error
                {
                    SloganDisplay displayError = new SloganDisplay();  //solgan
                    displayError.Display(); //display the slogan
                    Console.WriteLine("Please enter an avalible title\n Press Enter to continue"); //write and wait for user key strike
                    Console.ReadLine();
                    BuyInput();  //run the method again
                }

            }
            catch (Exception myerror) //error catch
            {
                Console.WriteLine(myerror.Message);
            }
        }
    }

    public class VideoCostCal
    {
        public double CostCal(double videoprice)
        {
            double myvideoprice = videoprice;
            double totalcost = (myvideoprice * .06) + myvideoprice;
            return totalcost;
        }
    }

    public class VideoBuyDisplay
    {
        public void VideoDisplay(string productName, double totalcost)
        {
            string finalProductName = productName;
            double finalRentcost = totalcost;
            Console.WriteLine("Thank you for buying " + finalProductName + "\n" + "The total cost is " + finalRentcost.ToString("C") + " (includes tax)" + "\n" + "Please press enter to return to the Video Menu");
            Console.ReadLine();
        }
    }
}
