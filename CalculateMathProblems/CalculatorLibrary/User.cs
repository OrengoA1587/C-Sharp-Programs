using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class User
    {
        private string _name;
        private string _age;


        public User(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                _name = value;
            }
        }
        public string Age
        {
            get
            {
                return _age;

            }
            set
            {
                _age = value;
            }
        }

    }

}
