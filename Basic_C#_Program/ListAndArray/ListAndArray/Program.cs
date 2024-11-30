using System.Collections.Generic;
using System.Runtime.InteropServices;

class program {
    static void Main(string[] args) {
        // create string array and added values
        string[] ArrayString = { "Hello", "World", "How", "Are", "you" };
        // asking for user input
        Console.WriteLine("Please Select the index from 0 to 4 :");
        int ustrin = Convert.ToInt32(Console.ReadLine());
        // check for condition to met is input is valid or not
        if (ustrin > 4) {
            // user massage if condition does not match
            Console.WriteLine("Please Enter Valid Number.");
        }
        else
        { 
            // user output when condition met
            Console.WriteLine(ArrayString[ustrin]);
        };

        // integer array created
        int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // asking for user input
        Console.WriteLine("Please enter the number between 0 to 9:");
        int usintin = Convert.ToInt32(Console.ReadLine());
        // check user input does met cliteria or not
        if (usintin > 9) {
            //if condition fails
            Console.WriteLine("Please Enter Valid Number.");
        }
        else {
            // if condition met true
            Console.WriteLine("you select the number :" + usintin);
        }
        //Massage for user to select from list
        Console.WriteLine("\nPlease select 0 to 7 :");
        // create list of string
        List<string> listStr = new List<string>();
        // adding value of strings to list
        listStr.Add("How Are You?");
        listStr.Add("How Do You Do?");
        listStr.Add("Where Are you?");
        listStr.Add("Can you Walk?");
        listStr.Add("You Are on Holidays?");
        listStr.Add("You Are Available?");
        listStr.Add("You Are Smart?");
        listStr.Add("What is Your Weight?");
        //user input
        int usliin = Convert.ToInt32(Console.ReadLine());
        // user input check
        if (usliin > 7)
        {
            // user input is not valid
            Console.WriteLine("Please Enter Valid Number: ");
        }
        else{
            // user input is valid
            Console.WriteLine(listStr[usliin]);
        }
    }
}