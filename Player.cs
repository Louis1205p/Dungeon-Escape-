using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonEscape
{
    public class Player
    {
        public int X { get; set; } // Playerens cordinater
        public int Y { get; set; } 
        public bool HasKey { get; set; } // boolean if the player dosent have or has the key

        public Player(int x, int y)
        {
            X = x; // x coordinate
            Y = y; // y coordinate
            HasKey = false; // The player dosent start with the key
        }
    }
}
