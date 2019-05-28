namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class FastFood
    {
        public static void Execute()
        {
            int quantity = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var orders = new Queue<int>(input);
            sb.AppendLine(orders.Max().ToString());

            while (orders.Any())
            {
                quantity -= orders.Peek();
                if (quantity >= 0)
                {
                    orders.Dequeue();
                }
                else
                {
                    sb.AppendLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }
            }
            
            if (orders.Count == 0)
            {
                sb.AppendLine("Orders complete");
            }

            Console.WriteLine(sb);
        }
    }
}
