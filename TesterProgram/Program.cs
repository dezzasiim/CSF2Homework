using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.FirstName = "Johnny";
            //s1.LastName = "Johnson";
            //s1.Id = "543321";
            //s1.Gpa = 3.3f;//couldnt enter in decimal places, why is that?
            //Console.WriteLine(s1);

            //Student s2 = new Student("Davie", "Davison", "12345", 4);
            //Console.WriteLine(s2);

            //Vehicle v1 = new Vehicle("Ford", "Fiesta", 1996, 2045);
            //Console.WriteLine(v1);

            //Vehicle v2 = new Vehicle();
            //v2.Make = "Dodge";
            //v2.Model = "Intrepid";
            //v2.Year = 1998;
            //v2.Weight = 2929;
            //Console.WriteLine(v2);

            //Login L1 = new Login();
            //L1.UserName = "HOBOB";
            //L1.Password = "GOBHAB";
            //Console.WriteLine(L1);

            //Login L2 = new Login("Harry", "Harry's password");
            //Console.WriteLine(L2);

            //ContactInfo c1 = new ContactInfo("1234 Mayflower Dr.", "Denver", "CO", "64601", "6460211", "Hoba@aol.com");
            //Console.WriteLine(c1);

            //ContactInfo c2 = new ContactInfo();
            //c2.StreetAddress = "2435 Rocky Rd.";
            //c2.City = "Belmont";
            //c2.State = "Me";
            //c2.Zip = "75758";
            //c2.Phone = "7578484";
            //c2.Email = "hoba2@yahoo.com";
            //Console.WriteLine(c2);

            //Customer cust1 = new Customer("73838", "Barry", "Bouncealot", new ContactInfo("1244","Burg","MO","67859","6868888","yop@aol.com"));
            //Console.WriteLine("\n"+ cust1);

            //Customer cust2 = new Customer();
            //cust2.CustomerId = "1234";
            //cust2.FirstName = "Susie";
            //cust2.LastName = "Barrington";
            //cust2.ContactInformation = new ContactInfo("12 Launch Ln", "chilli", "mo", "64692", "7478383", "he@aol.com");
            //Console.WriteLine("\n"+cust2);

            //CreditCardAccount CCA1 = new CreditCardAccount(1234, new Customer("1234", "Bob", "Smith", new ContactInfo("12 St.", "hapsburg", "MO", "64601", "6460111", "Hoj@aol.com")), 239.32m, true, 22.5m);
            //Console.WriteLine("\n"+CCA1);

            //CreditCardAccount CCA2 = new CreditCardAccount();
            //CCA2.AccountNumber =74747;
            //CCA2.CustomerInfo = new Customer("1324", "Jonnhy", "Samuels", new ContactInfo("12 Rd", "KC", "MO", "64052", "646474", "hap@aol.com"));
            //CCA2.Balance = 294.30m;
            //CCA2.IsPastDue = false;
            //CCA2.AnnualInterestRate = 4.4m;
            //Console.WriteLine("\n"+CCA2);

            //Book bk1 = new Book("How to win", "Dale Carnegie", 542);
            //Console.WriteLine("\n" + bk1);
            //Book bk2 = new Book();
            //bk2.Title = "7Habits";
            //bk2.Author = "Stephen Colvey";
            //bk2.NumberOfPages = 784;
            //Console.WriteLine("\n"+bk2);

            //List<Book> books = new List<Book>() { bk1, bk2 };
            //Library lb1 = new Library(books,"Livingston", "123 Clay", "chiill","MO","74740");
            //Console.WriteLine("\n"+ lb1);
            //Library lb2 =new Library();
            //lb2.Books = books;
            //lb2.LibraryName = "grundy";
            //lb2.StreetAddress = "422 Mud";
            //lb2.City = "trenton";
            //lb2.State = "MO";
            //lb2.Zip = "84848";
            //Console.WriteLine("\n"+lb2);

            Song s1 = new Song("McFly", "Missin U", 5555);
            Console.WriteLine(s1);
            Song s2 = new Song();
            s2.Artist = "Rickfly";
            s2.Title = "Dissin u";
            s2.LengthInSeconds = 4444;
            Console.WriteLine(s2+ "\n");

            List<Song> tracks = new List<Song>() { s1, s2 };
            Artist cd1 = new Artist(tracks, "CSF2", "Hard-Core Rap");
            Console.WriteLine(cd1 + "\n");
            Artist cd2 = new Artist();
            cd2.Tracks = tracks;
            cd2.Title = "csf2";
            cd2.Genre = "SOFTWARE WRAP";
            Console.WriteLine(cd2 + "\n");

            MotorHome sportsMobile = new MotorHome("Mercedes", "Sprinter", 2020, 5000, 6);
            Console.WriteLine(sportsMobile + "\n");
            MotorHome pleasureWay = new MotorHome();
            pleasureWay.Make = "Zimbabwe";
            pleasureWay.Model = "Zaire";
            pleasureWay.Year = 9999;
            pleasureWay.Weight = 0;
            pleasureWay.NumberOfBeds = 899;
            Console.WriteLine(pleasureWay + "\n");




        }
        
    }
}
