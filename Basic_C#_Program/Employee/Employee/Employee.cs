using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create generic class Employee
public class Employee<T> { 
    // Create generic list name things
    public List<T> things { get; set; }
    // create method with loop to print object
    public void print() {
        foreach (var item in things) {
            Console.WriteLine(item);
        }
    }
}
