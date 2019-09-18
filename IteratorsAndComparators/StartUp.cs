namespace Advanced.IteratorsAndComparators
{
    using System;

    public class StartUp
    {
        public static void Execute()
        {
            // Lab
            // Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            // Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            // Book bookThree = new Book("The Documents in the Case", 1930);

            // Library libraryOne = new Library();

            // SortedSet<Book> libraryTwo = new SortedSet<Book>(new BookComparator())
            // {
            //     bookOne,
            //     bookTwo,
            //     bookThree
            // };

            // foreach (Book book in libraryTwo)
            // {
            //     Console.WriteLine(book);
            // }

            // ListyIterator Exercise
            var input = Console.ReadLine();

            var commands = input.Split();

            ListyIterator<string> listy;

            if (commands.Length <= 1)
            {
                listy = new ListyIterator<string>();
            }
            else
            {
                var elements = new string[commands.Length - 1];
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = commands[i + 1];
                }

                listy = new ListyIterator<string>(elements);
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                switch (input)
                {
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        Console.WriteLine(listy.Print());
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "PrintAll":
                        Console.WriteLine(listy.PrintAll());
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        public static ListyIterator<T> Create<T>(params T[] elements)
        {
            return new ListyIterator<T>(elements);
        }
    }
}
