namespace Advanced.Generics.GenericScale
{
    using System;

    public class StartUp
    {
        public static void Execute()
        {
            var firstSet = new EqualityScale<int>(10, 5);

            Console.WriteLine(firstSet.AreEqual());
        }
    }
}