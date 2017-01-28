using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slogan;
using MainMenu_MainCase;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.IO;
using System.Threading;

namespace BlockBusterMain
{
    class BlockBusterProgram
    {
        
            static void Main(string[] args)
            {
                Process p = Process.GetCurrentProcess();
                ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3 Makes the console fullscreen

                var arr = new[]
                 {
    @" __    __    ___  _        __   ___   ___ ___    ___      ______   ___       ____   _       ___     __  __  _  ____   __ __  _____ ______    ___  ____  ",
    @"|  |__|  |  /  _]| |      /  ] /   \ |   |   |  /  _]    |      | /   \     |    \ | |     /   \   /  ]|  |/ ]|    \ |  |  |/ ___/|      |  /  _]|    \ ",
    @"|  |  |  | /  [_ | |     /  / |     || _   _ | /  [_     |      ||     |    |  o  )| |    |     | /  / |  ' / |  o  )|  |  (   \_ |      | /  [_ |  D  )",
    @"|  |  |  ||    _]| |___ /  /  |  O  ||  \_/  ||    _]    |_|  |_||  O  |    |     || |___ |  O  |/  /  |    \ |     ||  |  |\__  ||_|  |_||    _]|    / ",
    @"|  `  '  ||   [_ |     /   \_ |     ||   |   ||   [_       |  |  |     |    |  O  ||     ||     /   \_ |     \|  O  ||  :  |/  \ |  |  |  |   [_ |    \ ",
    @" \      / |     ||     \     ||     ||   |   ||     |      |  |  |     |    |     ||     ||     \     ||  .  ||     ||     |\    |  |  |  |     ||  .  \",
    @"  \_/\_/  |_____||_____|\____| \___/ |___|___||_____|      |__|   \___/     |_____||_____| \___/ \____||__|\_||_____| \__,_| \___|  |__|  |_____||__|\_|",
    @"",
    @"",
    @"              __ __  ____  ___      ___   ___   _____          ____   ____  ___ ___    ___  _____         ____    ___    ___   __  _  _____                  ",
    @"             |  |  ||    ||   \    /  _] /   \ / ___/         /    | /    ||   |   |  /  _]/ ___/        |    \  /   \  /   \ |  |/ ]/ ___/                  ",
    @"             |  |  | |  | |    \  /  [_ |     (   \_         |   __||  o  || _   _ | /  [_(   \_         |  o  )|     ||     ||  ' /(   \_                   ",
    @"             |  |  | |  | |  D  ||    _]|  O  |\__  |        |  |  ||     ||  \_/  ||    _]\__  |        |     ||  O  ||  O  ||    \ \__  |                  ",
    @"             |  :  | |  | |     ||   [_ |     |/  \ | __     |  |_ ||  _  ||   |   ||   [_ /  \ | __     |  O  ||     ||     ||     \/  \ |                  ",
    @"              \   /  |  | |     ||     ||     |\    ||  |    |     ||  |  ||   |   ||     |\    ||  |    |     ||     ||     ||  .  |\    |",
    @"               \_/  |____||_____||_____| \___/  \___||_ |    |___,_||__|__||___|___||_____| \___||_ |    |_____| \___/  \___/ |__|\_| \___| " ,                
    @"                                                       \|                                          \|                                        ",                









                 };
                
                Console.WriteLine("\n\n");
                var maxLength = arr.Aggregate(0, (max, line) => Math.Max(max, line.Length));
                var x = Console.BufferWidth / 2 - maxLength / 2;
                for (int y = -arr.Length; y < Console.WindowHeight + arr.Length; y++)
                {
                    Art drawArt = new Art();
                    drawArt.ConsoleDraw(arr, x, y);
                    Thread.Sleep(100);
                }
                //Console.WriteLine("Press Enter to Continue");
                //Console.ReadKey();



                int userInput = 0; //beginning value of 0 for userinput
                while (userInput != 4) //do this while userinput doesnt equal 4, on 4 we exit
                {
                    SloganDisplay displayBlock = new SloganDisplay(); //slogan created and called displayBlock
                    displayBlock.Display(); //slogan used
                    MainMenuClass mainMenuInstance = new MainMenuClass(); //main menu created and called mainMenuInstance
                    userInput = mainMenuInstance.MainMenu(); //userinput is collected from the .MainMenu
                    MainCaseClass mainCaseInstance = new MainCaseClass(); //main case created and called mainCaseInstance
                    mainCaseInstance.MainCase(userInput); //take userinput send it to .MainCase
                }
            }
            [DllImport("user32.dll")] //makes the console fullscreen, only works in windows 10
            public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow); //makes console fullscreen


        public class Art //makes the text move on screen, print and delete as we move down the screen
        {

            public void ConsoleDraw(IEnumerable<string> lines, int x, int y)
            {
                if (x > Console.WindowWidth) return;
                if (y > Console.WindowHeight) return;

                var trimLeft = x < 0 ? -x : 0;
                int index = y;

                x = x < 0 ? 0 : x;
                y = y < 0 ? 0 : y;

                var linesToPrint =
                    from line in lines
                    let currentIndex = index++
                    where currentIndex > 0 && currentIndex < Console.WindowHeight
                    select new
                    {
                        Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                        X = x,
                        Y = y++
                    };

                Console.Clear();
                foreach (var line in linesToPrint)
                {
                    Console.SetCursorPosition(line.X, line.Y);
                    Console.Write(line.Text);
                }
            }
        }
        }
    
}
