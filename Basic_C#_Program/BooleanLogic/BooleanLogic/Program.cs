// Title for programm to ensure user.
Console.WriteLine("This Program Check For Driving Under Influence(DUI)\n");
// asking for first condition user input
Console.WriteLine("What is Your Age? :");
// input take as string and convert in to integer and stored in variable
int uAge = Convert.ToInt32(Console.ReadLine());
// asking for second condition user input
Console.WriteLine("Have you ever had a DUI? (true/false) :");
// string input convert in to bool and store in variable
bool uDUI = Convert.ToBoolean(Console.ReadLine());
// asking for third condition user input
Console.WriteLine("How Many Speeding Tickets Do You Have? :");
// input take as string and convert in to integer and stored in variable
int utick = Convert.ToInt32(Console.ReadLine());

// create boolean variable and check conditions.
// if age is more than 13 and DUI is not equal to true or tickets are lower than 3 then user is qualified for driving.
bool quali = uAge > 15 && (uDUI != true ||  utick < 3);
// output to user 
Console.WriteLine("Are You Qualified to Drive? :"+quali);
// to wait for user input for end program


