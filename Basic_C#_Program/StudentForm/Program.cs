// Title massage along with Report name.
Console.WriteLine("Academy of Learning Career College \nStudent Daily Report.");
// asking for user name.
Console.WriteLine("What is Your Name? :");
// storing user value to variable.
string uname  = Console.ReadLine();
// asking for Course name.
Console.WriteLine("What Course are you on? :");
string course  = Console.ReadLine();
// asking for page number.
Console.WriteLine("What page number? :");
// taking parameter as string from user and convert them to int.
int PageNum = Convert.ToInt32(Console.ReadLine());
// Printing Question with escape sequence for quation marks.
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
// convert string to bool value.
bool uhelp = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
string exper = Console.ReadLine();
Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
string feedBack = Console.ReadLine();
Console.WriteLine("How many hours did you study today?");
//due to decimal value concatinate before convert.
double hours  = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

Console.WriteLine("Please Enter value for Math Oprations");
Console.WriteLine("Please Enter First Value :");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Second Value :");
int value2 = Convert.ToInt32(Console.ReadLine());
int addition = value1 + value2;
int substract = value1 - value2;
int multiply = value1 * value2;
int divide = value1 / value2;
int modulus = value1 % value2;
Console.WriteLine("The Addition of Value is :" + addition);
Console.WriteLine("The Substraction of Value is :" + substract);
Console.WriteLine("The Multiplication of Value is :" + multiply);
Console.WriteLine("The Division of Value is :" + divide);
Console.WriteLine("The Modulus of Value is :" + modulus);

