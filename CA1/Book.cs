using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{ public enum Genre
        {
            Fiction,
            Biography,
            Computing,
            Literature,

        }
    class Book:IComparable
    {
       
        //properties

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public Genre Genre { get; set; }

        // constructors
        public Genre(string title, string author, int pages, DateTime published, Genre genre )
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.Published = published;
            this.Genre = genre;


        }

       
        // method
        public override string ToString()
        {
            return string.Format("Title: {0} Author:{1} Published: {2}" +
                "Pages: {3} Genre: {4}", Title, Author, Published, Pages, Genre);
        }

        // compare to sort books by author and title
        public int CompareTo(object obj)
        {
            Book that = (Book)obj;

            //if (this.Author)
        }
    }
}
