// Title massage along with Report name.
Console.WriteLine("Academy of Learning Career College \nStudent Daily Report.");
// asking for user name.
Console.WriteLine("What is Your Name? :");
// storing user value to variable.
string uname = Console.ReadLine();
// asking for Course name.
Console.WriteLine("What Course are you on? :");
string course = Console.ReadLine();
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
double hours = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");


//------------------------MATH assignments

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

//---------------------------user input math problems
// multiplication section
Console.WriteLine("Please enter a number to multiply with 50 :");
// take input from user and convert it to int and multiply with 50.
int multi = Convert.ToInt32(Console.ReadLine())*50;
// show result to user by converting int to string
Console.WriteLine("Your Answer is :"+ Convert.ToString(multi));

// addition section
Console.WriteLine("Please Enter a number to add 25 :");
// take string value from user and convert it to int and add 25
int addi  = Convert.ToInt32(Console.ReadLine())+25;
Console.WriteLine("Your Answer is :"+ Convert.ToString(addi));

//division section
Console.WriteLine("Please Enter a number to divided by 12.5 :");
// take string input from user and convert to double and divide with 12.5
double divi  = Convert.ToDouble(Console.ReadLine())/12.5;
Console.WriteLine("Your Answer is : "+Convert.ToString(divi));

// true or false
Console.WriteLine("Please Enter a number to compare with 50");
// take string input from user and convert to int
int answ  = Convert.ToInt32(Console.ReadLine());
// compare the value is greater than 50 or not
bool resu = answ > 50;
Console.WriteLine(Convert.ToString(resu));

// modulus section
Console.WriteLine("Please Enter a number to ger remainder of 7 :");
// take string input from user and convert it to int
int val3 = Convert.ToInt32(Console.ReadLine());
// get remainder after devided by 7
int remain = val3 % 7;
Console.WriteLine("Your Remainder is : " + Convert.ToString(remain)); 

