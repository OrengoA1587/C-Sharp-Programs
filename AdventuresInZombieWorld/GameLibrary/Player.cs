using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player
    {
        private string _playerName = "";
        private string _playerPassword = "";
        private string _playerType = "";
        private int _playerHealth = 100;
        private int _playerPower = 25;
        private int _playerCoins = 0;



        public Player(string name, string password,string type, int health, int power, int coins)
        {
            Name = name;
            PlayerPassword = password;
            Type = type;
            Health = health;
            Power = power;
            Coins = coins;
        }

        public string Name
        {
            get { return _playerName; }
            set { _playerName = value; }
        }
        public string PlayerPassword
        {
            get { return _playerPassword; }
            set { _playerPassword = value; }
        }
        public string Type
        {
            get { return _playerType; }
            set { _playerType = value; }
        }
        public int Health
        {
            get { return _playerHealth; }
            set { _playerHealth = value; }
        }
        public int Power
        {
            get { return _playerPower; }
            set { _playerPower = value; }
        }
        public int Coins
        {
            get { return _playerCoins; }
            set { _playerCoins = value; }
        }

    }
}
