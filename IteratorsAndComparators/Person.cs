namespace Advanced.IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            var compareName = this.Name.CompareTo(other.Name);

            if (compareName == 0)
            {
                var compareAge = this.Age - other.Age;

                if (compareAge == 0)
                {
                    return this.Town.CompareTo(other.Town);
                }

                return compareAge;
            }

            return compareName;
        }
    }
}
