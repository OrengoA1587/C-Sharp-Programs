using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Mob
    {
        private string _mobName;
        private int _mobHealth;
        private int _mobPower;
        private int _mobCoins;



        public Mob(string name, int health, int power, int coins)
        {

        }

        public string Name
        {
            get { return _mobName; }
            set { _mobName = value; }
        }
        public int Health
        {
            get { return _mobHealth; }
            set { _mobHealth = value; }
        }
        public int Power
        {
            get { return _mobPower; }
            set { _mobPower = value; }
        }
        public int Coins
        {
            get { return _mobCoins; }
            set { _mobCoins = value; }
        }
    }
}
