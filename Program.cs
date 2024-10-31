using DungeonEscape;
using System;

class program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Welcome to Dungeon Espace, you must find a key hidden a one of the 16 rooms, but watchout for traps. GOOD LUCK! :)");
        Console.WriteLine(" ");
        Console.WriteLine("Schematic of the dungeon and all its rooms (you start at 0,0 which is the top left corner)");
        Console.WriteLine(" ");
        Console.WriteLine("  ? ? ? ?");
        Console.WriteLine("  ? ? ? ?");
        Console.WriteLine("  ? ? ? ?");
        Console.WriteLine("  ? ? ? ?");
        Console.WriteLine(" ");
        Game game = new Game(); // creates the game execution
        string input;
        while (true)
        {
            Console.WriteLine("Enter a direction (up, down, left, right):");
            input = Console.ReadLine();
            game.MovePlayer(input);
        }

    }

}