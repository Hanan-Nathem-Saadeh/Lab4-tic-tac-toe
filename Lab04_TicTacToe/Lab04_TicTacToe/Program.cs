using System;

namespace Lab04_TicTacToe.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("************ Welcome To Tic Tac Toe Game *************");
            Console.WriteLine("**************** HANAN NATHEM SAADEH *****************");
            Console.WriteLine("******************************************************");
            Console.WriteLine();
            StartGame();
        }
        /// <summary>
        /// StartGame Function to start the game with two players.
        /// </summary>
        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.Write("Name of Player One: ");
            string name1 = Console.ReadLine();
            Player PlayerOne = new Player
            {
                Name = name1,
                Marker = "X",
                IsTurn = true
            };
           
            Console.Write("Name of Player Two: ");
            string name2 = Console.ReadLine();
            Player PlayerTwo = new Player
            {
                Name = name2,
                Marker = "O",
                IsTurn = false
            };


            Game game = new Game(PlayerOne, PlayerTwo);
            Player winner = game.Play();

            if (winner == null)
                Console.WriteLine("Sorry !!! No One Win ");
            else
                Console.WriteLine($"Congratulations !!!, {winner.Name} is the WINNER.");
        }

    }


    }
