using System;
using System.Collections.Generic;

namespace cse210_03.Classes
{
    public class Player
    {
        // Make a list to trach all of the guessed letters.
        public List<char> LettersGuessed { get; set; } = new List<char>();

        public char MakeGuess()
        {
            /*
            This method prompts the user for a letter, converts it into a char and returns the char.
            */
            Console.Write("Guess a letter (a-z): ");
            string userLetter = Console.ReadLine();
            char userChar = char.Parse(userLetter);
            LettersGuessed.Add(userChar);

            return userChar;
        }
    }
}
