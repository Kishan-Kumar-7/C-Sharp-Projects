// Title for the application
Console.WriteLine("Anonymous Income Comparison Program\n\n");

// Person one user input 
Console.WriteLine("Person 1 \n Please Enter your Hourly Pay");
// user input string convert in to double 
double P1PayRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter Working Hours Per Week");
// user input string convert in to double
double P1WeekHours  = Convert.ToDouble(Console.ReadLine());

//Person two user input
Console.WriteLine("\nPerson 2 \n Please Enter your Hourly Pay");
// user input string convert in to double
double P2PayRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter Working Hours Per Week");
// user input string convert in to double
double P2WeekHours = Convert.ToDouble(Console.ReadLine());

// multiply payrate to weekly hours and yearly weeks
double P1Annu = P1PayRate * P1WeekHours * 52;
Console.WriteLine("\nAnnual Salary of Person 1 is : " + P1Annu);

// multiply payrate to weekly hours and yearly weeks
double P2Annu = P2PayRate * P2WeekHours * 52;
Console.WriteLine("\nAnnual Salary of Person 2 is : " + P2Annu);

// comparition section of annual salary of both person
bool comp = P1Annu > P2Annu;
Console.WriteLine("\n\nPerson 1 Makes More Money than Person 2");
// convert bool to string for output
Console.WriteLine(Convert.ToString(comp));