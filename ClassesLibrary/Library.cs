using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public Library()
        {

        }

        public override string ToString()
        {
            string libraryStock = "";

            foreach (Book book  in Books)
            {
                libraryStock += book;
            }
            return string.Format($"{libraryStock} {LibraryName} {StreetAddress} {City} {State} {Zip}");
        }
    }
}
