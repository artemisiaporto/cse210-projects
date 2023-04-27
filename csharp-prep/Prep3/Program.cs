using System;

class Program
{
    static void Main(string[] args)
    {
        int magicalNumber;
        int guess;

        Console.Write("What is the magical number? ");
        string answer1 = Console.ReadLine();
        magicalNumber = int.Parse(answer1);

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