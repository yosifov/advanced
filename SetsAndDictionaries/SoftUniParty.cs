namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class SoftUniParty
    {
        public static void Execute()
        {
            string expressiong = @"^[0-9]{1}[\w\d]*";

            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "party")
            {
                if (Regex.IsMatch(input, expressiong))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (Regex.IsMatch(input, expressiong))
                {
                    if (vipGuests.Contains(input))
                    {
                        vipGuests.Remove(input);
                    }
                }
                else
                {
                    if (regularGuests.Contains(input))
                    {
                        regularGuests.Remove(input);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            if (vipGuests.Count != 0)
            {
                foreach (var vipGuest in vipGuests)
                {
                    Console.WriteLine(vipGuest);
                }
            }
            if (regularGuests.Count != 0)
            {
                foreach (var regularGuest in regularGuests)
                {
                    Console.WriteLine(regularGuest);
                }
            }

        }
    }
}