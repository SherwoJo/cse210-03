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

            // Jumper Jumper = new Jumper();
            // while (Jumper.WrongGuesses < 5)
            // {
            //     Jumper.DrawJumper(Jumper.WrongGuesses);
            //     Jumper.WrongGuesses ++;
            // }
        }
    }
}
