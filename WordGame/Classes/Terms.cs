using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    class Terms
    {
        public static bool gameRunning = true;
        public static string command;
        //public static string ChrName;//CharacterName
        //public static int ChrHP;//Character HP
        private static string FolderName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private static string FileSave = FolderName + "\\Jonas Word Game";
      /*  private static string titleString = "\n\n" +
                              "\t\t\t------ ------ ------ --    ------\n" +
                              "\t\t\t------ ------ ------ --    ------\n" +
                              "\t\t\t  --     --     --   --    --\n" +
                              "\t\t\t  --     --     --   --    ------\n" +
                              "\t\t\t  --     --     --   --    ------\n" +
                              "\t\t\t  --     --     --   --    --\n" +
                              "\t\t\t  --   ------   --   ----- ------\n" +
                              "\t\t\t  --   ------   --   ----- ------\n" +
                              "\n\n\n\n";*/

        public string GetFileName()
        {
            return FileSave;
        }
    }
}
