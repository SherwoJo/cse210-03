using System;
using cse210_03.Classes;

namespace cse210_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Director Director = new Director();
            Director.StartGame();

            /*
            Testing the Jumper class
            */
            // Jumper Jumper = new Jumper();
            // while (Jumper.WrongGuesses < 5)
            // {
            //     Jumper.DrawJumper();
            //     Jumper.WrongGuesses ++;
            // }

            /*
            Testing the Puzzle class
            */
            // Puzzle Puzzle = new Puzzle();
            // for (int i = 0; i < 20; i ++)
            // {
            //     string word = Puzzle.GenerateWord();
            //     Console.WriteLine(word);
            // }

            /*
            Testing the Player class.
            */
            // Player Player = new Player();
            // for (int i = 0; i < 5; i ++)
            // {
            //     Player.MakeGuess();
            // }
            // foreach (char letter in Player.LettersGuessed)
            // {
            //     Console.WriteLine(letter);
            // }
        }
    }
}
