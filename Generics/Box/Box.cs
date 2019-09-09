namespace Advanced.Generics.Box
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            this.elements.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            var last = this.elements.Last();
            this.elements.RemoveAt(this.Count - 1);
            this.Count--;
            return last;
        }
    }
}
