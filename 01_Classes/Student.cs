using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    class Student : Person    // Student extends the Person class
    {


        // OVERLOADING - multiple constructors - will intelligently pick which constructor to use based on parameters you are given
        // Can overload methods too, based on the arguments they are given the correct one will be picked
        // Different from 'overwriting'
        // overloading is all about a difference in the number of parameters
        //public Student()
        //{


        //}


        //public Student(string fname)
        //{
        //    FirstName = fname;
        //}


        // Optional parameters go at the end
        public Student(string email, decimal debt, string fName = "no name added")
        {
            FirstName = fName;  // Inherited property from Person
            Email = email;  // Inherited property from Person
            Debt = debt;
        }

        public decimal Debt { get; set; }


        // 'override' means it is going to over-write an existing method from the parent
        public override void PrintFirstName()
        {
            Console.WriteLine("The student's name is: {0}", FirstName);
        }



    }
}
