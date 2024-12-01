// Assignment Part 1
// one Dimensional array of string
string[] Names = { "Johnny", "Maria", "John", "Rachel", "Jasse" };
// output for user to guess the name
Console.WriteLine("Please Type Your name :");
// taking user input
string uname = Console.ReadLine();
// creating list to add array and user input
List<string> listText = new List<string>();
// created loop same as length of array we have
for (int i = 0; i < Names.Length; i++)
{
    // each time loop run it took value from Names and concatinate with User input and extra text and add into List.
    listText.Add(Names[i] + " And " + uname + " are Friends.");
}
// iteration trough list each item
foreach (string text in listText)
{
    // print each string in list
    Console.WriteLine(text);
}

// Assignment Part 2

// creating infinite loop
// created boolvalue to check condition
bool infiloop = false;
// added counter as loop
int countLoop = 0;
// created loop which run infinite if condition met
while (!infiloop)
{
    // put condition to limit loop to 10 times
    if (countLoop < 10)
    {
        // adding one in to counter
        countLoop++;
        //print value of loop how many time run
        Console.WriteLine(countLoop.ToString());
    }
    // for ending loop 
    else
    {
        // change of bool value brake the loop
        infiloop = true;
    }
}

//Assignment Part 3
// loop with only < oprator
//Asking user for loop they want
Console.WriteLine("Please Enter a Number Of Loop You Want :");
int uLoop = Convert.ToInt32(Console.ReadLine());
// for loop to match with user input
for (int i = 0; uLoop > i; uLoop--)
{
    // this massage print to user every time loop run
    Console.WriteLine("You Will See This Massage More " + uLoop.ToString() + " Times.");
}

//loop Wth <= oprator
//Asking user for loop they want
Console.WriteLine("Please Enter a Number Of Loop You Want :");
int uLoops = Convert.ToInt32(Console.ReadLine());
for (int i = 0; uLoops >= i; uLoops--)
{
    // this massage print to user every time loop run
    Console.WriteLine("You Will See This Massage More " + uLoops.ToString() + " Times.");
}

//Assignment Part 4
// Create String List with Unique values
List<String> StrList = new List<string> { "apple", "grapes", "orenge", "banana", "mango" };

// Asking user to input string
Console.WriteLine("Please Enter Your Favorite Fruit Name :");
// store user input into variable and convert to lower case for comparision
string uFavFruit = Console.ReadLine().ToLower();
// assign default massage to user
string userMsg = "Sorry, We Do not Have Common Favorite Fruit";
// loop for list item to check
foreach (string str in StrList)
{
    // check user input with stored list matching
    if (str == uFavFruit)
    {
        // update user massage to matching
        userMsg = "Congratulations! We Have Common Favorite Fruit.";
        // exit loop 
        break;
    }
    // if not matching default massage to user
    else
    {
        userMsg = "Sorry, We Do not Have Common Favorite Fruit";
    }
}
// print user massage
Console.WriteLine(userMsg);

//Assignment Part 5
// creating string list
List<string> StList = new List<string>() { "red", "blue", "purple", "orange", "blue", "maroon", "yellow", "red" };
// user massage to input
Console.WriteLine("Please Enter Your Favorite Color :");
// asking user for input
string favCol = Console.ReadLine().ToLower();
// loop for iterates through list
foreach (string sList in StList)
{
    // check if condition is true or not
    if (sList == favCol)
    {
        // print massage to user each time condition match
        Console.WriteLine("Your Favorite Color " + favCol.ToUpper() + " is in Our List");
    }
    else
    {
        // print massage to user each time condition not match
        Console.WriteLine("Sorry, Your Favorite Color " + favCol.ToUpper() + " is Not in Our List. When Matched with " + sList.ToUpper());
    }
}

//Assignment Part 6
// creating a list of string
List<string> stringList = new List<string>() {"pen", "paper", "pencil","pen", "rubber", "notebook", "book", "paper", "rubber"};
// creating anothe list to add unique item list
List<string> copyList = new List<string>();
// creating foreach loop for go through all items
foreach (string str in stringList) {
    // this condition checks that stringList item is match with copyList item or not
    if (copyList.Contains(str)) {
        // if item match with copyList that mean item is reapeated
        Console.WriteLine("This Item is Duplicate");
    }
    // this else is for left defalut item for
    else
    { 
        // this line of code add item to copyList if it is unique
        copyList.Add(str); 
        // this code display user item is unique
        Console.WriteLine("This Item is Unique"); 
    }
}
