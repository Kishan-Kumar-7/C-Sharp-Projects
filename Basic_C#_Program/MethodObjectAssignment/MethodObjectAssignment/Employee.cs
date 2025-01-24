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
        public int Id { get; set; }

        public static bool operator== (Employee employee, Employee employee1) 
        {   
            bool employee3 = true;
           employee3 = employee.Id == employee1.Id;
            return employee3;

        }
        public static bool operator!= (Employee employee, Employee employee1) 
        {
            bool employee3 = true;
            employee3 = employee.Id != employee1.Id;
            return employee3;
        }
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