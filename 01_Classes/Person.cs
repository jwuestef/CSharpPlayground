using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    class Person
    {

        // ctor (tab tab)
        // Constructor
        //public Person(string fName, string email)
        //{
        //    FirstName = fName;
        //    Email = email;
        //}

        // prop (tab tab)
        // propfull (tab tab)  --- manually code your getter's and setter's
        // PROPERTIES - Pascal cased

        public string FirstName { get; set; }
        public string Email { get; set; }

        // ask about date type - how do you stoer dates?
        // ask about default values for constructor - and optional properties



        // METHODS
        // Order of things in a class:
        // fields - constructors - properties - methods
        // adding 'VIRTUAL' - means it allows this method to be overwritten in sub-classes
        public virtual void PrintFirstName()     // this line is the signature of the function... the stuff between the curly braces is the implementation
        {
            Console.WriteLine("Hello: {0}", FirstName);
        }


        public string GrabFirstName()
        {
            return this.FirstName;
        }


    }
}
