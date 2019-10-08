using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WordGame
{
    class StartMenu
    {
       public static void Menu()
        { 
            Console.Clear();
            Console.Write("1 Start Game \n2 Load Game \nQ Quit Game");
            Console.Write("\n\n\nPlease enter command:");
            Terms.command = Console.ReadLine().ToLower();

            switch (Terms.command)
            {
                case ("1"):
                case ("start"):
                case ("s"):
                case ("start game"):
                    Dialog.CryoDialog();
                    break;

                case ("2"):
                case ("l"):
                case ("load"):
                case ("load game"):
                    break;

                case ("q"):
                case ("quit"):
                    Terms.gameRunning = false;
                    break;

                default:
                    Console.WriteLine("Command not understood. Please try again.");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
    }
}
