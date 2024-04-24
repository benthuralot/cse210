using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine()); 

        string letter = ""; // Variable to store the letter grade
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check the last digit of grade to determine "+" or "-" sign.
        int lastDigit = grade % 10;

        if (grade == 100)
        {

        }
        else if (!(letter == "A" || letter == "F"))
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
        }
        else if (!(letter == "F"))
        {
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else
        {
            
        }

        // Check if the student passed the course
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter}{sign}.");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass. Better luck next time!");
        }

        // Print the letter grade separately
        Console.WriteLine($"Letter Grade: {letter}{sign}");

    }
}