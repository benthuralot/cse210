using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        int response = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (!(response == 0))
        {
            Console.WriteLine("Enter number: ");
            response =int.Parse(Console.ReadLine());

            if (response != 0)
            {
                numbers.Add(response);
            }

        }
        
        //Find the Largest Number
        int maxNum = 0;

        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        //Find the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }

        //Find the average
        float average = ((float)sum) / numbers.Count;

        //Find the smallest positive number
        int smallestNum = 0;
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                smallestNum = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        // Sort and display sorted List
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}