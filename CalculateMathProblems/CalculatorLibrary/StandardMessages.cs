using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StandardMessages
    {
        //Displays mainmenu to user
        public static string DisplayMainMenu()
        {
            return "Main Menu\n" +
                "1. Quadratic Formula\n" +
                "2. Slope Formula\n" +
                "3. Geometry Formulas\n" +
                "4. Divide\n" +
                "Esc. Exit";
        }

        //Displays mainmenu to user
        public static string DisplayGeometryMenu()
        {
            return "Plane Geometry\n" +
                "1. Area of Triangle\n" +
                "2. Pythagorean Theorem\n" +
                "3. Area of Rectangle\n" +
                "4. Area of Parallelogram\n" +
                "5. Area of Circle\n" +
                "6. Circumfrence of Circle\n" +
                "Esc. Exit";
        }

    }
}
