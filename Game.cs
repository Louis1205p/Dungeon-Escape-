using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonEscape
{
    public class Game
    {
        private LabyrinthRoom[,] labyrinth;
        Player player;

        // Constructroren til spillet
        public Game()
        {
            InitializeLabyrinth();
            player = new Player(0, 0);
        }

        // Method that creates the room/labyrinth
        private void InitializeLabyrinth()
        {
            labyrinth = new LabyrinthRoom[,]
            {
        { new LabyrinthRoom('.'), new LabyrinthRoom('.'), new LabyrinthRoom('T'), new LabyrinthRoom('.') },
        { new LabyrinthRoom('.'), new LabyrinthRoom('K'), new LabyrinthRoom('.'), new LabyrinthRoom('E') },
        { new LabyrinthRoom('.'), new LabyrinthRoom('.'), new LabyrinthRoom('T'), new LabyrinthRoom('.') },
        { new LabyrinthRoom('.'), new LabyrinthRoom('.'), new LabyrinthRoom('.'), new LabyrinthRoom('.') }
            };
        }

        // Method for movement
        // if else to change the players position based on the input
        public void MovePlayer(string direction)
        {
            int originalX = player.X; // start cords
            int originalY = player.Y; 

            if (direction == "up") player.Y -= 1;
            else if (direction == "down") player.Y += 1;
            else if (direction == "left") player.X -= 1;
            else if (direction == "right") player.X += 1;

            // checks if the position is valid
            if (player.X < 0 || player.X >= labyrinth.GetLength(1) || player.Y < 0 || player.Y >= labyrinth.GetLength(0))
            {
                Console.WriteLine("You cant go this way, try another direction"); 
                player.X = originalX; 
                player.Y = originalY; 
            }
            else
            {
                CheckRoom(); // check what room the player is in
            }
        }
        // Method checking for Key, Trap eller Exit
        private void CheckRoom()
        {
            LabyrinthRoom currentRoom = labyrinth[player.Y, player.X];

            if (currentRoom.Symbol == 'K') // if the room has the key
            {
                Console.WriteLine("You found the key");
                player.HasKey = true;
                currentRoom.Symbol = '.'; // room to empty
            }
            else if (currentRoom.Symbol == 'T') // If the room has a trap
            {
                Console.WriteLine("You fell into a trap, Game over.");
                ResetGame();
            }
            else if (currentRoom.Symbol == 'E') // If the room is the exit
            {
                if (player.HasKey) // Check if the player has the key
                {
                    Console.WriteLine("Congratulations! You found exit and won");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("This is the exit, but you dont have the key!"); 
                }
            }
            else // If the room is empty
            {
                Console.WriteLine("This room is empty."); 
            }
        }

        // method for losers
        private void ResetGame()
        {
            player = new Player(0, 0); // resets the players postion to the start (0,0)
            InitializeLabyrinth(); // Resets all rooms
        }
    }
}
