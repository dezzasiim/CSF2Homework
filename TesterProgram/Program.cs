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
        }
        
    }
}
