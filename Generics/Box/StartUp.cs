namespace Advanced.Generics.Box
{
    using System;

    public class StartUp
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentElement = Console.ReadLine();
                var currentBox = new BoxOfString<string>(currentElement);
                Console.WriteLine(currentBox.ToString());
            }
        }
    }
}
