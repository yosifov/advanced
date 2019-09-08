namespace Advanced.Generics.Box
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        public Box()
        {
            this.Elements = new List<T>();
            this.Count = 0;
        }

        public int Count { get; private set; }

        public List<T> Elements { get; set; }

        public void Add(T element)
        {
            this.Elements.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            var last = this.Elements.Last();
            this.Elements.RemoveAt(this.Count - 1);
            this.Count--;
            return last;
        }
    }
}
