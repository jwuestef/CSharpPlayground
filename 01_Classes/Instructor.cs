using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    class Instructor : Person
    {

        public Instructor(string firstName)
        {
            FirstName = firstName;
        }

        public Instructor(string fName, string email, string classesTaught)
        {
            FirstName = fName;  // Inherited property from Person
            Email = email;  // Inherited property from Person
            ClassesTaught = classesTaught;
        }

        public string ClassesTaught { get; set; }



        public override void PrintFirstName()
        {
            Console.WriteLine($"The instructor's name is {FirstName}");
        }

    }
}
