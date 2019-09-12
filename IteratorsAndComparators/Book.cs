namespace Advanced.IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;

    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            var compareYear = this.Year - other.Year;

            if (compareYear == 0)
            {
                return this.Title.CompareTo(other.Year);
            }

            return compareYear;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
