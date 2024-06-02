using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address nzAddress = new Address("178 Surrey Crescent", "Auckland", "AKL 1021 ", "New Zealand");
        Address ausAddress = new Address("410 Stanley Street", "South Brisbane", "QLD 4101", "Australia");
        Address usAddress = new Address("525 S Center", "Rexburg","ID 83460", "USA");

        // Create one Event of each type
        Lecture lec = new Lecture("CSE210", "Programming with Classes", "2/6/2024", "9:00am", usAddress, "Chad Macbeth", 50);
        Reception rec = new Reception("Wedding", "Mr & Mrs Seumanu", "7 September 2019", "10am", nzAddress, "seumanuwedding@gmail.com");
        Outdoor outd = new Outdoor("Polyfest", "Polynesian Culture Festival", "3 April 2024", "8am - 6pm", ausAddress, "Hot and Sunny");

        // Display results by calling Event Methods
        Console.WriteLine(lec.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lec.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(lec.DisplayShortDescription());
        Console.WriteLine("\n====================\n");
        
        Console.WriteLine(rec.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(rec.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(rec.DisplayShortDescription());
        Console.WriteLine("\n====================\n");

        Console.WriteLine(outd.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outd.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(outd.DisplayShortDescription());
        Console.WriteLine("\n====================\n");
    }
}