using System;
using System.Collections.Generic;

namespace cse210_03.Classes
{
    public class Puzzle
    {
        private List<string> Words { get; set; } = new List<string> {"cook", "snail", "pencil", "nose", "ladybug", "mailbox", "mountain", "paper", "orange", "boot", "fork", "lawyer", "balloon", "apples", "airport", "volleyball", "grape", "sheep", "crayon", "calendar"};

        Random rnd = new Random();

        public string GenerateWord()
        {
            /*
            This method selects a ramdom word from the list above and returns it.
            */
            int index = rnd.Next(0, Words.Count);
            string word = Words[index];

            return word;
        }
    }
}
