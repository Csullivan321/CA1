using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            // objects created
            Book b1 = new Book("Harry Potter", "Stephen F", 600, 09 /12 /2008,"literature");
            Book b2 = new Book("Hobbit", "James Joyce", 600, '15/12/2006', "literature");
            Book b3 = new Book("Jango", "Fk Rowling", 600, '13/07/2008', "literature");
            Book b4 = new Book("Steve Jobs", "Walter Isacson", 600, '08/09/2009', "literature");
            Book b5 = new Book("C Sharp", "Stephen F", 600, '05/06/2017', "literature");
            
            // creating a list
            List<Book> ReadingList = new List<Book>();
            ReadingList.Add(b1);
            ReadingList.Add(b2);
            ReadingList.Add(b3);
            ReadingList.Add(b4);
            ReadingList.Add(b5);

            //Array.Sort(ReadingList);
            Display(ReadingList);
            Console.WriteLine();
            

        }

        static void Display(List<Book>books)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Title", "Author", "Pages", "Published", "Genre");

            //loop through all books
            foreach(Book book in books)
            {
                Console.Write("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10",book.Title, book.Author, book.Pages,
                    book.Published, book.Genre);
            }

            Console.WriteLine();


        }
    }
}
