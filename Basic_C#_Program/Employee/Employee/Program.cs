using Employee;
// initializing Employee object with string type
Employee<string> employee = new Employee<string>();

// Creating string list
employee.things = new List<string>();
//assigning multiple values to list 
employee.things.Add("Hello ");
employee.things.Add("World");

// initializing Employee object with int type 
Employee<int> employee2 = new Employee<int>();
//creating int list
employee2.things = new List<int>();
employee2.things.Add(111);
employee2.things.Add(555);

//print using method
employee.print();
employee2.print();