using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }


        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} is by {1} and has {2} pages.",Title,Author,NumberOfPages);
        }
    }
}
