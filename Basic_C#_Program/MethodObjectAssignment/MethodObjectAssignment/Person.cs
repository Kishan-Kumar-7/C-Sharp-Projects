using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{   
    // create public abstract class person with two properties and one method
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // create method to pring full name on screen due to absract class method is now virtual
        public virtual void SayName()
        { 
            string  FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: "+FullName);
        }
    }
}
