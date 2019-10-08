using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            var gR = Terms.gameRunning;
            var terms = new Terms();
            string fileSave = terms.GetFileName();
            
            if (!System.IO.Directory.Exists(fileSave)) {
                System.IO.Directory.CreateDirectory(fileSave);
                //This creates a file on the desktop to save everything. Using this due to not wanting
                //to create a real folder on the harddrive. Easily findable and deletable. 
            }
            /*else
            {
                MessageBox.Show("File Exists", "Existing File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //This pops up a small message box.
            }*/

            while (Terms.gameRunning)
            {
                Title.Start();
            }
        }
    }
}
