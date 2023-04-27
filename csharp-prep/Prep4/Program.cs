using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        int sum;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            numbers.Add(number);
        } while (number != 0);

        sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
    }
}