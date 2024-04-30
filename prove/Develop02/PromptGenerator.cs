public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>();

       _prompts.Add("How was your day today?");
       _prompts.Add("If I had one thing I could do over today, What would it be?");
       _prompts.Add("What was the best part of my day?");
       _prompts.Add("Who was the most interesting person you interacted with today?");
       _prompts.Add("What was the most challenging thing I faced today?");
       _prompts.Add("What am I grateful for today?");
       _prompts.Add("What did I do today that I am proud of?");
       _prompts.Add("What was the worst thing that happened today?");
       _prompts.Add("What was the best thing that happened today?");
       _prompts.Add("What are my top priorities for the day?");
       _prompts.Add("What am I nervous or anxious about today?");
       _prompts.Add("What was a small detail I noticed today?");
       _prompts.Add("What was the weather like today?");
       _prompts.Add("How can I make tomorrow even better?");
       _prompts.Add("What did I learn today?");

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int idx = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[idx];
        return randomPrompt;
    }
}