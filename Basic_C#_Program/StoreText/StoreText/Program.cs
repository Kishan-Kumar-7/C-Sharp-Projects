//adding the library for input output textfile
using System.IO;

//adding welcoming massage
Console.WriteLine("Welcome to the World of Technologies.");
// massage for user input and string input from user saved in variable
Console.Write("Please Enter Your First Name : ");
string fName = Console.ReadLine();
Console.Write("Please Enter Your Last Name : ");
string lName = Console.ReadLine();
// Massage for User input for number 
Console.Write("Please Enter Your Contact Number : ");
// getting input from user in string and convert in to int32
int cNumb = Convert.ToInt32(Console.ReadLine());
// concatinate fname, lname and Contact number to create text
string UDetails = ("Your Full Name Is : "+fName+" "+lName+". \nYour Contact Number is : "+cNumb);
//writing variable Udetails to text file and store it
File.WriteAllText(@"C:\Users\Kisha\Documents\Study\Pitman\008 C# and DotNET Framework - Part 2\Names.txt", UDetails);
//retrieve data from file and store variable
string fileText = File.ReadAllText(@"C:\Users\Kisha\Documents\Study\Pitman\008 C# and DotNET Framework - Part 2\Names.txt");
// output from file to display
Console.WriteLine(fileText);