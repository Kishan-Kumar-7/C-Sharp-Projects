// title for the programm
Console.WriteLine("\n\t Welcome to Package Express\n\nPlease Follow The Instructions Below.\n\n");
// screen massage for user to enter weight of package
Console.WriteLine("Please Enter Weight Of Your Package :");
// get input from user as string convert to int and store in variable
int pWeight = Convert.ToInt32(Console.ReadLine());
// check first condition if weight is more than 50 than show msg or go to else 
if (pWeight > 50)
{   
    // Print Weight Condition faliure result
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
}
// second condition Weight Condition Sucsess result
else
{
    // User input question
    Console.WriteLine("Please Enter Package Height in Inches :");
    // recive input convert to int and store in variable
    int pHeight = Convert.ToInt32(Console.ReadLine());
    // User input question
    Console.WriteLine("Please Enter Package Width in Inches :");
    // recive input convert to int and store in variable
    int pWidth = Convert.ToInt32(Console.ReadLine());
    // User input question
    Console.WriteLine("Please Enter Package lenght in Inches :");
    // recive input convert to int and store in variable
    int pLength = Convert.ToInt32(Console.ReadLine());
    // Size Condition check and result
    Console.WriteLine(pLength+pHeight+pWidth > 50? "Package too big to be shipped via Package Express.": "Your Estimated Total for Shipping This Package is :$" + (pHeight * pWidth * pLength * pWeight / 100) + ".\n\nThank You.\n\nVisit Again....");
}