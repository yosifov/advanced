namespace Advanced.Generics.GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var customArray = new T[length];

            for (int i = 0; i < length; i++)
            {
                customArray[i] = item;
            }

            return customArray;
        }
    }
}
