using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
using System.Windows.Forms;
using System.IO;
namespace ConsoleUI
{   

    class Program
    {
        
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();//Enables visuals for windows form view
            Player gamePlayer; //Create Player object
            CreatePlayerForm createPlayer = new CreatePlayerForm();//Create form class for CreatePlayerForm
            StartForm startForm = new StartForm();
            //Declare variables
            bool menuLoop = false;
            //Set keyboard input class
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

             
            Application.Run(new StartForm());
             
            Application.Run(new MainMenu());
            do
            {
                //Get keyboard input from user
                Console.WriteLine(StandardMessage.DisplayMainMenu());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    //Start Zombie Adventure
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        
                        Application.Run(new CreatePlayerForm());
                         
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //Login Verification
                        Application.Run(new LoginForm());

                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        break;
                    default:
                        menuLoop = true;
                        break;

                }
                Console.Clear();
            } while (menuLoop == false);
            Console.ReadLine();
        }
    }
}
