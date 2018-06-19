using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    class Coach : Person
    {

        public Coach(string fName, string email, int numberOfProspects)
        {
            FirstName = fName;  // Inherited property from Person
            Email = email;  // Inherited property from Person
            NumberOfProspects = numberOfProspects;
        }

        public int NumberOfProspects { get; set; }
    }
}
