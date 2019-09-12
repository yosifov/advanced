namespace Advanced.IteratorsAndComparators
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            var compareTitle = first.Title.CompareTo(second.Title);

            if (compareTitle == 0)
            {
                return first.Year - second.Year;
            }

            return compareTitle;
        }
    }
}
