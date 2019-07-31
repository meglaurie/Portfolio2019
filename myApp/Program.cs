using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class Program
{
		static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guess;

            List<int> enteredNumbers = new List<int>();

            bool gameOver = false;
            // CHANGE
            var duplicateNumber = false;
            // END CHANGE

            Console.WriteLine("I'm thinking of a number between 1 and 100 what is it?");

            while (gameOver == false)
            {
                duplicateNumber = false; // NOT NEEDED BUT GOOD PRACTICE
                guess = Convert.ToInt32(Console.ReadLine());

                // CHANGE
                if (!enteredNumbers.Contains(guess))
                {
                    enteredNumbers.Add(guess);
                }
                else
                {
                    duplicateNumber = true;
                    Console.WriteLine($"You have already entered {guess}");
                }
                if (!duplicateNumber)
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Higher");
                    }

                    else if (guess == randomNumber)
                    {
                        //Console.WriteLine("You guessed the right number"); // CHANGE
                        gameOver = true;
                    }
                }
                // END CHANGE
            }
            // CHANGE
            Console.WriteLine($"You guessed the number in {enteredNumbers.Count} " + (enteredNumbers.Count == 1 ? "attempt!" : "attempts."));
            // END CHANGE
            Console.ReadLine();
        }
 }
}
