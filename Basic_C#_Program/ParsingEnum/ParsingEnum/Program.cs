// Enter whole program in try catch method will prevent from unexpected errors
try {
    // Welcome Massage and User Input Massage
    Console.WriteLine("Hello Everyone Here We are Going to Compare Days of Week");
    Console.WriteLine("Could You Please Enter Current Day of Week ");
    // asking user to input today and using trim deleting extra space
    String ToDay = Console.ReadLine().Trim();

    //Parse the input into Enum type if the user input is true or match with our Enum
    DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), ToDay,true);
    //Showing Result
    Console.WriteLine("So, Today is {0}. What a Lovely Day!",dayOfWeek);
}
// This will return the massage to user to enter valid day
catch(Exception) {
    Console.WriteLine("Please Enter Actual Day Of Week.");
}