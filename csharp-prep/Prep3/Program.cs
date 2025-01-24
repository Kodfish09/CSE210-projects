using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        bool play = false;
        do {
            Console.WriteLine("What is the Magic Number? ");
            int magNum = int.Parse(Console.ReadLine());
            bool gsd = false;
            int guessNum = 0;

            while (gsd == false) {
                Console.WriteLine("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                guessNum += 1;

                if (guess < magNum) {
                    Console.WriteLine("Higher\n");
                } else if (guess > magNum) {
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It only took you {guessNum} guesses! ");
                    gsd = true;
                }
            }
            Console.WriteLine("Do you want to play again? ");
            string playAgain = Console.ReadLine();
            if (playAgain == "Yes" || playAgain == "yes") {
                play = true;
            } else {
                play = false;
            }
        } while (play == true);
    }
}