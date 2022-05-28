using System;

namespace cse210_03.Classes
{
    public class Jumper
    {
        public int WrongGuesses { get; set; } = 0;

        public void DrawJumper()
        {
            /*
            This method draws the Jumper character with his parachute
            which shrinks as wrong guesses are made.
            */
            // Draw the appropriate lines of the parachute depending on how many wrong guesses have occured.
            if (WrongGuesses < 1)
            {
                Console.WriteLine(" ___");
            }
            if (WrongGuesses < 2)
            {
                Console.WriteLine(@"/___\");
            }
            if (WrongGuesses < 3)
            {
                Console.WriteLine(@"\   /");
            }
            if (WrongGuesses < 4)
            {
                Console.WriteLine(@" \ /");
            }

            // Draw the Jumper's head as an 'O' or an 'X' depending on how many wrong guesses there are.
            if (WrongGuesses < 4)
            {
                Console.WriteLine("  O");
            }
            if (WrongGuesses >= 4)
            {
                Console.WriteLine("  X");
            }

            // Draw the rest of the Jumper's body
            Console.WriteLine(@" /|\");
            Console.WriteLine(@" / \");
            Console.WriteLine("\n");
        }
    }
}
