namespace Advanced.IteratorsAndComparators
{
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private List<T> elements;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
            this.currentIndex = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (this.currentIndex + 1 < this.elements.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Print()
        {
            if (this.elements.Count <= 0)
            {
                return "Invalid Operation!";
            }
            else
            {
                return $"{this.elements[this.currentIndex]}";
            }
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }
    }
}
