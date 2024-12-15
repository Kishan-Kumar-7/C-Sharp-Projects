using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{   
    // create public class person with two properties and one method
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // create method to pring full name on screen
        public void SayName()
        { 
            string  FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: "+FullName);
        }
    }
}
