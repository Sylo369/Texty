using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texty.Menus
{
    public class Menu
    {
        public static void Intro()
        {
            Console.WriteLine("Welcome to Texty. ver 0.1");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("(Create) a new text file");
            Console.WriteLine("(Read) an existing file");
            Console.WriteLine("(Exit) the app");
            Console.WriteLine();
            Console.WriteLine("Tip: Write the wanted action that is in brackets.");
            string command = Console.ReadLine().ToLower();
            Console.Clear();

            switch (command)
            {
                case "create":
                    Create();
                    break;
                case "read":
                    Read();
                    break;
                case "exit":
                    Exit();
                    break;
                default:
                    Unknown();
                    break;
            }
        }
        static void Create()
        {
            Console.WriteLine("What is the name of the file: ");
            Console.WriteLine("Tip: Try simple names, because there is no added filter for valid names yet.");
            string textFileName = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(@$"../../../{textFileName}.txt"))
            {
                Console.WriteLine("What is the message: ");
                string textMessage = Console.ReadLine();
                writer.WriteLine(textMessage);
            }
            Console.WriteLine("Your text file with the message has been created.");
            Console.WriteLine("Press any key to return to the main menu:");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }
        static void Read()
        {
            Console.WriteLine("What is the name of the text file?");
            string textFileName = Console.ReadLine();
            using (StreamReader reader = new StreamReader($@"../../../{textFileName}.txt"))
            {
              string content = reader.ReadToEnd();
              Console.WriteLine(content);
                
            }
            Console.WriteLine("This is the message from the file.");
            Console.WriteLine("Press any key to return to the main menu:");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }
        static void Exit()
        {
            Console.WriteLine("Thank you for using Texty!");
            Console.WriteLine("Have a beautiful and peaceful day.");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        static void Unknown()
        {
            Console.WriteLine("Unknown command. Try again.");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }
    }
}
