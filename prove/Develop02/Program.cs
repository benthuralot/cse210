using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string theDate = theCurrentTime.ToShortDateString();
        Journal newJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while(true)
        {
            PromptGenerator promptGenerator= new PromptGenerator();
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write($"> ");
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(theDate, randomPrompt, entryText);
                newJournal.AddEntry(newEntry);
            }

            else if (userChoice == 2)
            {
                newJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the file name?");
                string fileName = Console.ReadLine();
                newJournal.LoadFromFile(fileName);                
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                newJournal.SaveToFile(file);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Goodbye.");
                break;
            }

        }
    }
}