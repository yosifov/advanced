namespace Advanced.SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EvenTimes
    {
        public static void Execute()
        {
            int lines = int.Parse(Console.ReadLine());
            var elements = new Dictionary<int, int>();

            for (int i = 0; i < lines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!elements.ContainsKey(number))
                {
                    elements.Add(number, 0);
                }
                elements[number]++;
            }

            elements = elements.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var element in elements)
            {
                Console.WriteLine(element.Key);
            }
        }
    }
}