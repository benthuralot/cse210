using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi",2,24);
        string text = "But behold, all things have been done in the wisdom of him who knoweth all things.";
        
        Scripture scripture = new Scripture(reference, text);
        
        do
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
            Console.Clear();
               
        }while(scripture.IsCompletelyHidden() != true);
    }
}