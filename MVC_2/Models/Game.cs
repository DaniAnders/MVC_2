using System;
using Microsoft.AspNetCore.Mvc;

namespace MVC_2.Models
{
    public class Game
    {
        public static string? Result { get; set; }
        public static int Attempts { get; set; }
        public static int RandomNumber { get; set; }
        public static bool Win { get; set; }
        public static int Score { get; set; }


        public static int GetRandomNumber()
        {
            Win = false;
            Score = 0;
            Attempts = 1;
            Random rand = new Random();
            return rand.Next(1, 101);
        
        }

        public static string Guess(string guess)
        {
            int.TryParse(guess, out int guess_);
            if (string.IsNullOrEmpty(guess))
            {
                Result = "Error! Invalid Value.";
            }
            if (guess_ < 1 || guess_ > 100)
            {
                Result = "The number you try to guess is between (1 to 100)";
            }
            else
            {
                if (guess_ == RandomNumber)
                {
                    Result = $"Congratulations you won!!! Attempts: {Attempts}";
                    Win = true;
                    Score = Attempts;
                }
                else
                {
                    if (guess_ > RandomNumber)
                    {
                        Result = $"Sorry! You guessed too high. Try again! Attempts: {Attempts}";

                    }
                    else
                    {
                        Result = $"Sorry! You guessed too low. Try again! Attempts: {Attempts} ";
                    }
                    Attempts++;
                }
            }

            return Result;
        }
    }
}

