using MethodObjectAssignment;
// using class employee with inheritance of class person
Employee employee = new Employee();
// assign values to class person
employee.Id = 01;
employee.FirstName = "Sample";
employee.LastName = "Student";
// adding another object name employee1
Employee employee1 = new Employee();
employee1.Id = 01;
employee1.FirstName = "New";
employee1.LastName = "Employee";
// as result of comparision come bool you will get result in emp and emd 
bool emp = employee == employee1;
bool emd = employee != employee1;
Console.WriteLine(emp);
Console.WriteLine(emd);

// using method from superclass person
employee.SayName();
employee.Quit(employee);
