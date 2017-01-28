using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using MainMenuOptions;
using BooksMain_MainMenu_MainCase;
using VideoGameMain_MainMenu_MainCase;
using VideoMain_MainMenu_MainCase;

namespace MainMenu_MainCase
{
    public class MainMenuClass
    {
        public int MainMenu()
        {
            MainMenuOptionsClass MenuOptions = new MainMenuOptionsClass(); //main options created and called MenuOptions
            MenuOptions.Options(); //call .Options class
            int result = 0; //result set to zero
            try
            {
                result = int.Parse(Console.ReadLine()); //userinput taken in and parsed to an int called result
                return result; //return what is in result
            }
            catch (Exception myerror) //exception catching
            {
                Console.WriteLine(myerror.Message);
            }
            return result; //return result if the above passed
        }
    }

    public class MainCaseClass
    {
        public void MainCase(int results)
        {
            int myInput; //will be the variable tthat has the userinput in it
            myInput = results;
            switch (myInput)//based on userinput a case is chossen if applicable
            {
                case 1: //video menu
                    SloganDisplay videoSlogan = new SloganDisplay(); //slogan 
                    videoSlogan.Display(); //slogan displayed
                    VideoMainClass Video = new VideoMainClass(); //Video Main class called Video
                    Video.Video(); //.Video called
                    break;

                case 2: //Books menu
                    SloganDisplay bookSlogan = new SloganDisplay(); //slogan
                    bookSlogan.Display(); //slogan displayed
                    BooksMainClass Books = new BooksMainClass();//Book Main class called Books
                    Books.Books();//.Books called
                    break;

                case 3: //Video Game menu
                    SloganDisplay gamesSlogan = new SloganDisplay(); //slogan
                    gamesSlogan.Display(); //slogan displayed
                    VideoGamesMainClass VideoGames = new VideoGamesMainClass(); //Video Games Main called VideoGames
                    VideoGames.VideoGameMain();//.VideoGamesMain called
                    break;

            }
        }
    }

}
