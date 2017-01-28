using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using VideoGameOptions;
using VideoGamesRent;
using VideoGameBuy;

namespace VideoGameMain_MainMenu_MainCase //same notes as video main dll
{
    public class VideoGamesMainClass
    {
        public void VideoGameMain()
        {
            int userInput = 0;
            while (userInput != 3)
            {
                SloganDisplay errorSlogan = new SloganDisplay();
                errorSlogan.Display();                          
                VideoGamesMainMenuClass NewVideoMenu = new VideoGamesMainMenuClass();
                userInput = NewVideoMenu.VideoGameMenu();
                VideoGameCaseClass VideoCase = new VideoGameCaseClass();
                VideoCase.VideoGameCase(userInput);
            }
        }
    }

    public class VideoGamesMainMenuClass
    {
        public int VideoGameMenu()
        {
            VideoGamesOptionsClass VideoGamesMenuOptions = new VideoGamesOptionsClass();
            VideoGamesMenuOptions.Options();
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

    public class VideoGameCaseClass
    {
        public void VideoGameCase(int results)
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
                    Rent gamesRent = new Rent();
                    gamesRent.RentInput();
                    break;

                case 2: //Buy
                    SloganDisplay buySlogan = new SloganDisplay();
                    buySlogan.Display();
                    VideoGamesBuyClass buy = new VideoGamesBuyClass();
                    buy.BuyInput();
                    break;

                case 3://goes back one screen
                    break;

            }
        }
    }
}
