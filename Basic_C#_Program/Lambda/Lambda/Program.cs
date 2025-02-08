using Lambda;
using System.Collections.Generic;
// using Employees class creating list to store data
List<Employees> employee = new List<Employees>();
// creating employee1 for adding details in object
Employees employee1 = new Employees();
//assign values to object
employee1.Id = 1;
employee1.FirstName = "Sam";
employee1.LastName = "Maddy";
// adding object to list of employee
employee.Add(employee1);

employee1.Id = 2;
employee1.FirstName = "Sammy";
employee1.LastName = "Mad";
employee.Add(employee1);


employee1.Id = 3;
employee1.FirstName = "Joe";
employee1.LastName = "Max";
employee.Add(employee1);

employee1.Id = 4;
employee1.FirstName = "Joseph";
employee1.LastName = "Smith";
employee.Add(employee1);

employee1.Id = 5;
employee1.FirstName = "John";
employee1.LastName = "Sammy";
employee.Add(employee1);

employee1.Id = 6;
employee1.FirstName = "Peter";
employee1.LastName = "bandt";
employee.Add(employee1);

employee1.Id = 7;
employee1.FirstName = "Joe";
employee1.LastName = "Steave";
employee.Add(employee1);

employee1.Id = 8;
employee1.FirstName = "Jasson";
employee1.LastName = "Smith";
employee.Add(employee1);

employee1.Id = 9;
employee1.FirstName = "Kay";
employee1.LastName = "Riyana";
employee.Add(employee1);

employee1.Id = 10;
employee1.FirstName = "Brandon";
employee1.LastName = "Spears";
employee.Add(employee1);

// creating new list of employees for filter Joe
List<Employees> empl = new List<Employees>();
// looping trough the list
foreach (Employees employ in employee) {
    // applying condition for filter
    if (employ.FirstName == "Joe")
    {
        //creating Employees object for filter object
        Employees emplo = new Employees();
        emplo.Id = employ.Id;
        emplo.FirstName = employ.FirstName;
        emplo.LastName = employ.LastName;
        empl.Add(emplo);
    }
}
// creating list for filter object with lambda base condition filter
List<Employees> emp = employee.Where(x => x.Id == 5).ToList();

// printing result of first list
foreach (Employees AAA in empl) { 
    Console.WriteLine(AAA.Id);
    Console.WriteLine(AAA.FirstName);
    Console.WriteLine(AAA.LastName+"\n");
}
// printing result of second list
foreach (Employees BBB in emp)
{
    Console.WriteLine(BBB.Id);
    Console.WriteLine(BBB.FirstName);
    Console.WriteLine(BBB.LastName + "\n");
}