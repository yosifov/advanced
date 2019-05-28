namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicStackOperations
    {
        public static void Execute()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToPop = input[1];
            int searchElement = input[2];

            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(elements);

            int maxPops = Math.Min(stack.Count, elementsToPop);

            for (int i = 1; i <= maxPops; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
