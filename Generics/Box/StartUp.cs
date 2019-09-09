namespace Advanced.Generics.Box
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Execute()
        {
            // Generic Swap Method Strings
            // int n = int.Parse(Console.ReadLine());

            // var listOfBoxes = new List<BoxOfString<string>>();

            // for (int i = 0; i < n; i++)
            // {
            //     var currentElement = Console.ReadLine();
            //     var currentBox = new BoxOfString<string>(currentElement);
            //     listOfBoxes.Add(currentBox);
            // }

            // var indexes = Console.ReadLine()
            //     .Split();
            // int firstIndex = int.Parse(indexes[0]);
            // int secondIndex = int.Parse(indexes[1]);

            // SwapElements(listOfBoxes, firstIndex, secondIndex);

            // listOfBoxes
            //     .ForEach(x => Console.WriteLine(x.ToString()));

            // Generic Count Method Strings
            int n = int.Parse(Console.ReadLine());
            var listOfStrings = new List<string>();

            for (int i = 0; i < n; i++)
            {
                listOfStrings.Add(Console.ReadLine());
            }

            var compareElement = Console.ReadLine();

            Console.WriteLine(GreaterElements(listOfStrings, compareElement));
        }

        public static void SwapElements<T>(List<T> list, int firstIndex, int secondIndex)
        {
            var firstIndexElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstIndexElement;
        }

        public static int GreaterElements<T>(List<T> list, T compareElement)
            where T : IComparable
        {
            return list.Where(x => x.CompareTo(compareElement) > 0).ToList().Count;
        }
    }
}