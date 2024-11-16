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