namespace Advanced.Generics.GenericArrayCreator
{
    public class StartUp
    {
        public static void Execute()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
        }
    }
}
