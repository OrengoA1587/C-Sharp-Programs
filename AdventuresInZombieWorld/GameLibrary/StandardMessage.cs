using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class StandardMessage
    {
        public static string DisplayMainMenu()
        {
            return "Main Menu\n" +
                "1. Start New Adventure\n" +
                "2. Continue Adventure\n" +
                "3. Settings\n" +
                "4. Player Stats\n" +
                "5. Exit";
        }
        public static string DisplaySettingsMenu()
        {
            return "Main Menu\n" +
                "1. Start Adventure\n" +
                "2. Settings\n" +
                "3. Player Stats\n" +
                "4. Exit";
        }
        public static string DisplayPlayerMenu()
        {
            return "Player Menu\n" +
                "1. Player 1\n" +
                "2. Player 2\n" +
                "3. Player 3\n" +
                "4. Player 4\n" +
                "5. Main Menu";
        }
    }
}
