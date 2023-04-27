using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        int sum;
        float average;
        int largest;
       
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        largest = 0;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
            largest = num;                
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}