using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BookRepository
    {
        public List<Book> Books { get; set; }

        public void DisplayallBooks()
        {
            foreach(Book b in Books)
            {
                Console.WriteLine($"{b.BookId} {b.Title} {b.Price} {b.Publisher}");
            }
        }
        public void DisplayBookByPublisher(string publisher)
        {
            foreach (Book b in Books)
            {
                if (b.Publisher == publisher)
                {
                    Console.WriteLine($"{b.BookId} {b.Title} {b.Price} {b.Publisher}");
                }
            }
        }
    }
}
