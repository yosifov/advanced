namespace Advanced.Generics.Box
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());

            var listOfBoxes = new List<BoxOfString<string>>();

            for (int i = 0; i < n; i++)
            {
                var currentElement = Console.ReadLine();
                var currentBox = new BoxOfString<string>(currentElement);
                listOfBoxes.Add(currentBox);
            }

            var indexes = Console.ReadLine()
                .Split();
            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);

            SwapElements(listOfBoxes, firstIndex, secondIndex);

            listOfBoxes
                .ForEach(x => Console.WriteLine(x.ToString()));
        }

        public static void SwapElements<T>(List<T> list, int firstIndex, int secondIndex)
        {
            var firstIndexElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstIndexElement;
        }
    }
}