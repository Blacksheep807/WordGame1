using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WordGame
{
    class Menu
    {
         public static void MenuScreen()
        {
            StreamWriter fileOutPut;
            var terms = new Terms();
            string fileSave = terms.GetFileName();
            string savedGame = fileSave + "\\SavedGame";

            Console.Clear();
            Console.WriteLine("Welcome to the menu");
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Return to game\n");
            Console.WriteLine("Save game\n");
            Console.WriteLine("Load game\n");
            Console.WriteLine("Quit game");
            Console.Write("\n\n\nPlease enter command:");
            Terms.command = Console.ReadLine().ToLower();

            switch (Terms.command)
            {
                case ("s"):
                case ("save"):
                case ("save game"):
                    Console.Write("Please Input Save Name:");
                    string saveName = Console.ReadLine().ToUpper();
                    string gameFile = savedGame + '\\' + saveName;
                    
                    fileOutPut = File.CreateText(gameFile + ".txt");

                    if (!Directory.Exists(savedGame))
                    {
                        Directory.CreateDirectory(savedGame);
                    }
                    if (!File.Exists(gameFile))
                    {
                        fileOutPut = File.CreateText(gameFile + ".txt");
                        //fileOutPut.WriteLine(Inventory.items().toString()) ;
                        MessageBox.Show(saveName + ".txt created", "File Created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        fileOutPut.Close();
                        MenuScreen();
                    }
                    else
                    {
                        Console.Write("Do you want to save over " + saveName + "?");
                        string answer = Console.ReadLine().ToLower();
                        try
                        {
                            if (answer == "yes" || answer == "y")
                            { /*fileOutPut.WriteLine(Inventory.items().toString());*/

                                
                                MessageBox.Show(saveName + ".txt Updated", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                fileOutPut.Close();
                                MenuScreen();
                            }
                            else
                            {
                                
                                MessageBox.Show("Please Try Again, File Was Not Created", "File Not Created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                fileOutPut.Close();
                                MenuScreen();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;

                case ("l"):
                case ("load"):
                case ("load game"):
                    break;

                case ("q"):
                case ("quit game"):
                case ("quit"):
                    Terms.gameRunning = false;
                    break;

                default:
                    Console.WriteLine("Command not understood. Please try again.");
                    Console.ReadKey();
                    Menu.MenuScreen();
                    break;
            }
        }
    }
}
