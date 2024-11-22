// Title for programm
Console.WriteLine("Turnery Oprator Programm\n");

//Asking for user input
Console.WriteLine("Please Enter your Age :");
// taking string and convert in to integer and store in variable
int uAge = Convert.ToInt32(Console.ReadLine());
// compare integer to fixed value with turnery oprator and storing msg in uMsg variable
string uMsg = uAge >= 20? "You are An Adult.":"You are not An Adult.";
// Display the output to user
Console.WriteLine(uMsg);