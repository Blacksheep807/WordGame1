using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    class Title
    {
        public static void Start()
        {
            string TitleString1= "\n\n------ ------ ------ --    ------\n";
            string TitleString2 = "------ ------ ------ --    ------\n"+
                "  --     --     --   --    --\n"+
                "  --     --     --   --    ------\n"+
             "  --     --     --   --    ------\n"+
             "  --     --     --   --    --\n"+
                      "  --   ------   --   ----- ------\n"+
                       "  --   ------   --   ----- ------\n\n\n\n\n";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            Console.WindowHeight = Console.LargestWindowHeight-20;
            Console.WindowWidth = Console.LargestWindowWidth-20;
            int Height = Console.WindowHeight;
            int width = Console.WindowWidth;
            Console.CursorLeft = (width - TitleString1.Length) / 2;
            int leftIndent = Console.CursorLeft;
            MessageBox.Show("The Height of the screen is: " + Height +"\nThe Width of the screen is: " +width, "Dimensions",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Console.Clear();
            Console.SetCursorPosition(leftIndent, Console.CursorTop);
            Console.WriteLine(TitleString1 + TitleString2);
            Console.ForegroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(3000);

            StartMenu.Menu();
        }
    }
}
