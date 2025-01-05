using System;

namespace Assignment.MiniAssignment2
{
    public class GuessingGame
    {
        public void PlayGame()
        {
            int correctNumber = new Random().Next(3)+1;
            int userGuess = 0; //default value

            Console.WriteLine("Guess the number between 1 and 3:");

            while (userGuess != correctNumber)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < correctNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (userGuess > correctNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                }
            }
        }
    }
}