namespace Advanced.Generics.Box
{
    public class BoxOfString<T> where T : class
    {
        private T element;

        public BoxOfString(T element)
        {
            this.element = element;
        }

        public override string ToString()
        {
            return $"{this.element.GetType()}: {this.element}";
        }
    }
}
