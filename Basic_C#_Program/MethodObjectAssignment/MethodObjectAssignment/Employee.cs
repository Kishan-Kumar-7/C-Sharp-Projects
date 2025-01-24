using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{
    // using this class to use employee id and inheritance from person class
    public class Employee : Person, IQuitteble
    {
        // overrideing the method of base inheritance from person 
        public override void SayName()
        {
            Console.WriteLine("List of Employee");
            // calling the pearson method here
            base.SayName();
        }
        public void Quit(Person person)
        {
            Console.WriteLine("Employee says \n I Quit.");
        }
    }
}