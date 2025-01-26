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
        // adding a Employee id to compare
        public int Id { get; set; }
        // overloading operator with comparision
        // as we are comparing two objects we will get result either true or false
        public static bool operator== (Employee employee, Employee employee1) 
        {   
            // setting up bool variable to get result of employee comarision
            bool employee3 = true;
            // compairing two employees id
           employee3 = employee.Id == employee1.Id;
            //returning the bool value
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