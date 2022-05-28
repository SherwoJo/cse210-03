using System;
using System.Collections.Generic;

namespace cse210_03.Classes
{
    public class Director
    {
        public void StartGame()
        {
            /*
            This method does the initial setup of the game and then starts the main gameplay loop
            */

            // Create an instance of each class.
            Jumper Jumper = new Jumper();
            Player Player = new Player();
            Puzzle Puzzle = new Puzzle();

            // Generate a random word that the player will try to guess.
            string word = Puzzle.GenerateWord();

            // Parse the word into an array of characters and get the length.
            char[] letters = word.ToCharArray();
            int lenLetters = letters.Length;

            // Create a list of booleans which will track whether a letter has been guessed or not.
            List<bool> boolList = new List<bool>();
            foreach (char letter in letters)
            {
                boolList.Add(false);
            }

            // Start the main gameplay loop.
            bool stillPlaying = true;
            while (stillPlaying)
            {
                // Draw the jumper and the spaced-out word.
                Jumper.DrawJumper(letters, boolList);
                // Prompt the user to guess a letter.
                char userGuess = Player.MakeGuess();

                // See if the letter is in the word.
                int index = 0;
                bool letterFound = false;
                foreach (char letter in letters)
                {
                    if (userGuess == letter)
                    {
                        // If the letter is in the word, then update the tracking list.
                        boolList[index] = true;
                        letterFound = true;
                    }
                    index ++;
                }

                // If the letter was not in the word, then increment the WrongGuesses counter.
                if (letterFound == false)
                {
                    Jumper.WrongGuesses += 1;
                }

                // Check if the player has either won or lost.
                bool gameWon = true;
                bool gameLost = false;
                foreach (bool item in boolList)
                {
                    if (item == false)
                    {
                        gameWon = false;
                    }
                }
                if (Jumper.WrongGuesses >= 4)
                {
                    gameLost = true;
                }

                // Display a "game over" message if the game is finished.
                if (gameWon)
                {
                    Jumper.DrawJumper(letters, boolList);
                    Console.WriteLine("Congratulations! You guessed the word.");
                    Console.WriteLine($"It took you {Player.LettersGuessed.Count} tries to guess the word.");
                    Console.Write("Here are your guesses: ");
                    foreach (char letter in Player.LettersGuessed)
                    {
                        Console.Write(letter + ", ");
                    }
                    stillPlaying = false;
                }
                else if (gameLost)
                {
                    Jumper.DrawJumper(letters, boolList);
                    Console.WriteLine("You lost! The jumper has fallen!");
                    Console.WriteLine($"The word was: {word}");
                    Console.WriteLine("Better luck next time.");
                    stillPlaying = false;
                }
            }
            Console.WriteLine("\nThanks for playing!");
        }
    }
}
