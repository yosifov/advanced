namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    class UniqueUsernames
    {
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
