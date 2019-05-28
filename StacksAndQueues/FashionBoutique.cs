namespace Advanced.StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FashionBoutique
    {
        public static void Execute()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var clothesInBox = new Stack<int>(input);
            int boxesCount = clothesInBox.Count;
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCount = 1;

            int currentClothes = 0;

            while(clothesInBox.Count != 0)
            {
                currentClothes += clothesInBox.Peek();
                if (currentClothes <= rackCapacity)
                {
                    clothesInBox.Pop();
                }
                else
                {
                    rackCount++;
                    currentClothes = 0;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
