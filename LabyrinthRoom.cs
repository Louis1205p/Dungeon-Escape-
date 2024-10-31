using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonEscape
{
    public class LabyrinthRoom
    {
        // char to save and get the symbols, K, T, E
        public char Symbol { get; set; } 

        public LabyrinthRoom(char symbol)
        {
            Symbol = symbol;
        }
    }
}
