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
            //     Jumper.DrawJumper(Jumper.WrongGuesses);
            //     Jumper.WrongGuesses ++;
            // }

            /*
            Testing the Puzzle class
            */
            // Puzzle Puzzle = new Puzzle();
            // int i = 0;
            // while (i < 20)
            // {
            //     string word = Puzzle.GenerateWord();
            //     Console.WriteLine(word);
            //     i ++;
            // }
        }
    }
}
