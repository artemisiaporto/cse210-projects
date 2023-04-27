using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicalNumber = randomGenerator.Next(1, 100);
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string answer2 = Console.ReadLine();
            guess = int.Parse(answer2);

        if (magicalNumber < guess)
        {
            Console.WriteLine("Lower");
        }

        if (magicalNumber > guess)
        {
            Console.WriteLine("Higher");
        }

        if (magicalNumber == guess)
        {
            Console.WriteLine("You guessed it!");
        }

        } while (magicalNumber != guess);


    }
}