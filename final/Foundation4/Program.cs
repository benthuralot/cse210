using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a List that takes is Activity objects
        List<Activity> activities = new List<Activity>();

        // Create one of each Activity
        Running running = new Running("03 May 2023", 90, 3);
        Cycling cycling = new Cycling("04 May 2023", 60, 15);
        Swimming swimming = new Swimming("05 May 2023", 20, 5);

        // Add the activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        
        // Loop through the List and call the GetSummaryString() method to display the right values 
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummaryString());
        }
    }
}