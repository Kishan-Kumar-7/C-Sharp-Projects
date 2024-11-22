// Title for User understanding
Console.WriteLine("This Programm will return value if condition met");

// asking user input for condition checking
Console.WriteLine("Please Enter Your Age :");
// taking user input as string add convert in to integer and store in to variable uAge
int uAge = Convert.ToInt32(Console.ReadLine());

// Cheking Conditions and reply
// if age is under 13 reply is child.
if (uAge <= 12) {
    Console.WriteLine("You are Child!");
}
// if age is between 13 to 19 reply is teenager
else if (uAge <= 19){
    Console.WriteLine("You are Teenager!");
}
// and age is grater than 19 reply is adult
else {
    Console.WriteLine("You are Adult!");
}