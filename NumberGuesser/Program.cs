using System;

namespace NumberGuesser
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {



                // Init correct number

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var 
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Its not a number, please try again");

                        continue;
                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Write out app info            
                        Console.WriteLine("Wrong number, please try again");

                        // Reset text color
                        Console.ResetColor();
                    }


                }

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Congratulations! You guessed the right number!!!");

                Console.ResetColor();

                Console.WriteLine("Would you like to play again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }


            }

        }

        static void GetAppInfo()
        {
            // set app vars 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Flavio H Sousa";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info            
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");
        }

        static void GreetUser() {
            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, lets play a game...");
        }
    }
}
