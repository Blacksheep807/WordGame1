using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WordGame
{
    class Dialog
    {
        public string ToXmlString()
        {

        }

        public static void CryoDialog()
        {
            Console.Clear();
            Console.Write(
                "You awaken to the light red flashing of emergency lights.\n" +
                "You are encased in a glass tube that is slimy to the touch.\n" +
                "Something once occupied this tube with you. As you struggle\n" +
                "move you find yourself encased in tubes and wires. Quickly\n" +
                "you are able to disengage the alien objects from your body\n" +
                "but in doing so, you have found yourself dislodged from the\n" +
                "tube. You are laying on the ground in front of a single tube\n" +
                "surrounded by several other broken and shattered tubes. \n" +
                "A single red light flashes over a door to the south of you." 
                );

            Console.Write("\n\n\nWhat is your command?");
            Terms.command = Console.ReadLine().ToLower();

            switch (Terms.command)
            {
                /*case ("look"): 
                    Console.WriteLine*/

                case ("menu"): Menu.MenuScreen();
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
