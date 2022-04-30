using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MenuKey
    {
        private int _Key;


        public MenuKey(int keys)
        {
            Keys = keys;
        }

        int Keys
        {
            get
            {
                return _Key;
            }
            set
            {
                _Key = value;
            }
        }
    }
}
