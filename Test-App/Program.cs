using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Link";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool OutOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    OutOfGuesses = true;
                }
            } while (secretWord != guess && !OutOfGuesses);
            if (OutOfGuesses)
            {
                Console.WriteLine("You Lose!");
            } else
            {
                Console.WriteLine("You Win!");
            }
            Console.ReadLine();
        }
    }
}
