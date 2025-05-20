using System;

namespace _homework_6_task_bonus
{
    public class Program
    {
        static void Main()
        {
            string storedUsername = "user123";
            string storedPassword = "pass456";

            int attemptCoint = 0;
            bool loggedIn = false;

            while (!loggedIn && attemptCoint < 3)
            {
                Console.Write("Enter username: ");
                string? inputUsername = Console.ReadLine()?.Trim() ?? "";

                Console.Write("Enter password: ");
                string? inputPassword = Console.ReadLine()?.Trim() ?? "";


                if (inputUsername == storedUsername && inputPassword == storedPassword)
                {
                    Console.WriteLine($"Welcome {inputUsername}");
                    loggedIn = true;
                }
                else
                {
                    attemptCoint++;
                    Console.WriteLine($"Incorrect credentials. Attempts left: {3 - attemptCoint}");
                }
            }

            if (!loggedIn)
            {
                Console.WriteLine("Maximum login attempts reached. Access denied.");
            }
        }
    }
}
