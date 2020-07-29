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
            Student s1 = new Student();
            s1.FirstName = "Johnny";
            s1.LastName = "Johnson";
            s1.Id = "543321";
            s1.Gpa = 3.3f;//couldnt enter in decimal places, why is that?
            Console.WriteLine(s1);

            Student s2 = new Student("Davie", "Davison", "12345", 4);
            Console.WriteLine(s2);

            Vehicle v1 = new Vehicle("Ford", "Fiesta", 1996, 2045);
            Console.WriteLine(v1);

            Vehicle v2 = new Vehicle();
            v2.Make = "Dodge";
            v2.Model = "Intrepid";
            v2.Year = 1998;
            v2.Weight = 2929;
            Console.WriteLine(v2);

            Login L1 = new Login();
            L1.UserName = "HOBOB";
            L1.Password = "GOBHAB";
            Console.WriteLine(L1);

            Login L2 = new Login("Harry", "Harry's password");
            Console.WriteLine(L2);

            ContactInfo c1 = new ContactInfo("1234 Mayflower Dr.", "Denver", "CO", "64601", "6460211", "Hoba@aol.com");
            Console.WriteLine(c1);

            ContactInfo c2 = new ContactInfo();
            c2.StreetAddress = "2435 Rocky Rd.";
            c2.City = "Belmont";
            c2.State = "Me";
            c2.Zip = "75758";
            c2.Phone = "7578484";
            c2.Email = "hoba2@yahoo.com";
            Console.WriteLine(c2);

            Customer cust1 = new Customer("73838", "Barry", "Bouncealot", new ContactInfo("1244","Burg","MO","67859","6868888","yop@aol.com"));
            Console.WriteLine("\n"+ cust1);

        }
        
    }
}
