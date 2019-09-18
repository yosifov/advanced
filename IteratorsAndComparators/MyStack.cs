namespace Advanced.IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public MyStack()
        {
            this.elements = new List<T>();
        }

        public void Push(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.elements.Add(elements[i]);
            }
        }

        public void Pop()
        {
            if (this.elements.Count > 0)
            {
                this.elements.RemoveAt(this.elements.Count - 1);
            }
            else
            {
                Console.WriteLine($"No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}