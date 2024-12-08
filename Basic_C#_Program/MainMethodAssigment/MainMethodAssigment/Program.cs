using MainMethodAssigment;
//creating math2 class
math2 math2 = new math2();

//call the first method with integer
Console.WriteLine(math2.Multi(7));
//call second method with decimal
Console.WriteLine(math2.Multi(7.9m));
//call third method with string
Console.WriteLine(math2.Multi("7"));

//Method Assignment 2
// asking user to input value
Console.WriteLine("Please Enter First Value :");
int val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Optional Second Value :");
// this will prevent from error of empty second value
try
{
    // this will run if user enter two values
    int val2 = Convert.ToInt32(Console.ReadLine());
    int result = math2.opti(val1, val2);
    Console.WriteLine("You Entered {0} and {1} and Answer is {2}",val1, val2, result);
}
catch {
    //this will run if user enter only one value
    int result = math2.opti(val1);
    Console.WriteLine("You Entered {0} X Default value 1 = {1}",val1,result);
}

