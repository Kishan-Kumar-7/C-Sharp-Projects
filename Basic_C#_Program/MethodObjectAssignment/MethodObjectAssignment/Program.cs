using MethodObjectAssignment;
// using class employee with inheritance of class person
Employee employee = new Employee();
// assign values to class person
employee.FirstName = "Sample";
employee.LastName = "Student";
// using method from superclass person
employee.SayName();
employee.Quit(employee);