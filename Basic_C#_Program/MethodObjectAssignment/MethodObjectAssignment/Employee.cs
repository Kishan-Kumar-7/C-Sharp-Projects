using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{
    // using this class to use employee id and inheritance from person class
    public class Employee : Person
    {
        // overrideing the method of base inheritance from person 
        public override void SayName() {
            Console.WriteLine("List of Employee");
            // calling the pearson method here
            base.SayName();
        }
    }
    
}
