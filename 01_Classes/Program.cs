using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student paul = new Student();
            //paul.FirstName = "Paul";
            //paul.Email = "poconnor@elevenfifty.org";


            //string name = "Paul";
            string name;  // Declaration
            name = "Paul";  // Initialization

            decimal debt = 100.00m;

            Student paul = new Student("poconnor@elevenfifty.org", debt, name);

            // cw (tab) for Console.WriteLine
            Console.WriteLine(paul.FirstName);

            Console.ReadLine();



            // Call methods on a class
            Person johnQ = new Person();
            johnQ.FirstName = "John";
            johnQ.PrintFirstName();

            string johnsName = johnQ.GrabFirstName();

            Console.ReadLine();



            Student angie = new Student("awashburn@elevenfifty.org", debt, "Angie");
            angie.PrintFirstName();


            Instructor jonathan = new Instructor("Jonathan");
            jonathan.PrintFirstName();



        }
    }
}
