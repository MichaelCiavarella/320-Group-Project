using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using VideoRent;
using VideoMainOptions;
using VideoBuy;

namespace VideoMain_MainMenu_MainCase //same notes as the books buy dll
{
    public class VideoMainClass
    {
        public void Video()
        {
            int userInput = 0;
            while (userInput != 3)
            {
                SloganDisplay errorSlogan = new SloganDisplay();
                errorSlogan.Display();
                VideoMainMenuClass NewVideoMenu = new VideoMainMenuClass();
                userInput = NewVideoMenu.VideoMenu();
                VideoCaseClass VideoCase = new VideoCaseClass();
                VideoCase.VideoCase(userInput);
            }
        }
    }

    public class VideoMainMenuClass
    {
        public int VideoMenu()
        {
            VideoOptionsClass VideoMenuOptions = new VideoOptionsClass();
            VideoMenuOptions.Options();
            int result = 0;
            try
            {
                result = int.Parse(Console.ReadLine());
                return result;
            }
            catch (Exception myerror)
            {
                Console.WriteLine(myerror.Message);

            }
            return result;
        }
    }
    public class VideoCaseClass
    {
        public void VideoCase(int results)
        {
            int myInput;
            myInput = results;
            switch (myInput)
            {
                case 0:
                    SloganDisplay zeroSlogan = new SloganDisplay();
                    zeroSlogan.Display();
                    break;

                case 1: //Rent
                    SloganDisplay rentSlogan = new SloganDisplay();
                    rentSlogan.Display();
                    Rent newRent = new Rent();
                    newRent.RentInput();
                    break;

                case 2: //Buy
                    SloganDisplay buySlogan = new SloganDisplay();
                    buySlogan.Display();
                    VideoBuyClass newBuy = new VideoBuyClass();
                    newBuy.BuyInput();
                    break;

                case 3://goes back on screen

                    break;


            }
        }
    }
}
