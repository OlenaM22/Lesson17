using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> votes = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a vote topic:");
        string topic = Console.ReadLine();
        Console.WriteLine($"The topic is: {topic}");

        while (true)
        {
            Console.WriteLine("Enter an option or type 'done' to finish:");
            string option = Console.ReadLine();

            if (option.ToLower() == "done")
                break;

            votes[option] = 0;
        }

        while (true)
        {
            Console.WriteLine("Vote for an option or type 'results' to see the results:");
            string vote = Console.ReadLine();

            if (vote.ToLower() == "results")
                break;

            if (votes.ContainsKey(vote))
                votes[vote]++;
            else
                Console.WriteLine("Invalid option. Please try again.");
        }

        Console.WriteLine("Voting results:");
        foreach (var pair in votes)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
