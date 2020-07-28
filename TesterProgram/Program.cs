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
            s1.Gpa = 3;//couldnt enter in decimal places, why is that?
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


        }
        
    }
}
