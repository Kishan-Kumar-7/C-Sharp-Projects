// Title for Do While loop programm
Console.WriteLine("This Programm is for Loops Checking\n\n");
// Asking for User Input
Console.WriteLine("Please Select a Number Between 1 to 100.");
// storing user input in to variable
int unum = Convert.ToInt32(Console.ReadLine());
// Do While Loop 
do
{
    Console.WriteLine("You Will See This Msg for More "+ unum + " Times.");
    unum--;
}
// Loop stop when Condition met
while (0 < unum);

Console.WriteLine("Please Enter a Number to Check While Loop :");
int Wnum = Convert.ToInt32(Console.ReadLine());
// While loop
while (0 < Wnum) {
    Console.WriteLine("This Msg Generated with Help Of While Loop.");
    Wnum--;
};