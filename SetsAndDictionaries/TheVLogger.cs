namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheVLogger
    {
        public static void Execute()
        {
            string command = Console.ReadLine();

            var followers = new Dictionary<string, Dictionary<string, int>>();
            var following = new Dictionary<string, Dictionary<string, int>>();


            while (command.ToLower() != "statistics")
            {
                if (command.Contains("joined"))
                {
                    string vlogerName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                    if (!followers.ContainsKey(vlogerName))
                    {
                        followers[vlogerName] = new Dictionary<string, int>();
                    }
                    if (!following.ContainsKey(vlogerName))
                    {
                        following[vlogerName] = new Dictionary<string, int>();
                    }
                }

                if (command.Contains("followed"))
                {
                    string vlogerName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                    string followedName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];

                    if (!(vlogerName == followedName) && followers.ContainsKey(followedName) && followers.ContainsKey(vlogerName))
                    {
                        if (!followers[followedName].ContainsKey(vlogerName))
                        {
                            followers[followedName].Add(vlogerName, 0);
                        }
                        if (!following[vlogerName].ContainsKey(followedName))
                        {
                            following[vlogerName].Add(followedName, 0);
                        }
                        followers[followedName][vlogerName]++;
                        following[vlogerName][followedName]++;
                    }
                    
                }

                command = Console.ReadLine();
            }

            followers = followers.OrderByDescending(x => x.Value.Count).ThenBy(x => following[x.Key].Values.Count).ToDictionary(x => x.Key, x => x.Value);

            int counter = 1;

            Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
            foreach (var vloggerKvp in followers)
            {
                Console.WriteLine($"{counter}. {vloggerKvp.Key} : {vloggerKvp.Value.Count} followers, {following[vloggerKvp.Key].Count} following");
                if (counter == 1)
                {
                    foreach (var followerName in vloggerKvp.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"*  {followerName.Key}");
                    }
                }
                counter++;
            }
        }
    }
}
