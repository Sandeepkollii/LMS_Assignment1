using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }
    }

    class Work
    {
        public string Title { get; set; }

        public Work(string title)
        {
            Title = title;
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
            Author author = new Author(name);
            Work book1 = new Work("Sample Book");
            Author nullAuthor = null;

            Console.WriteLine($"Comparing Author name from Author class__________________");
            Console.WriteLine($"Is {author.Name} Author? : {author is Author}");

            Console.WriteLine($"Comparing book1 from Author class__________________");
            Console.WriteLine($"Is book1 belongs to class Author? : {book1 is Author}");

            Console.WriteLine($"Taking the author name as null__________________");
            Console.WriteLine($"Is {author.Name} Author? : {nullAuthor is Author}");
        }
    }
}

