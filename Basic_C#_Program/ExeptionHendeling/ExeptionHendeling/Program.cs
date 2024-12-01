using System.Reflection.Metadata;
// this method catch error when user enter wrong input
try
{
    // Title for user to know program
    Console.WriteLine("This Program has Fixed List of Number Which will Devided by Number You Enter\n");
    List<int> listNum = new List<int>() { 25, 33, 12, 24, 46, 21, 40, 51, 8 };
    // Another massage for user to requst
    Console.WriteLine("Please Enter Number of Your Choice : ");
    // asking user input
    int usrNum = Convert.ToInt32(Console.ReadLine());
    //loop for each item in list
    foreach (int numb in listNum)
    {
        //showing result if everything is ok
        Console.WriteLine(numb + " / " + usrNum + " = " + numb / usrNum);
    }
}
// catch error if user input 0
catch (DivideByZeroException ex)
{
    Console.WriteLine("Please enter a Numbers is not Divizible with zero");
}
// catch error if user input string
catch (FormatException ex)
{
    Console.WriteLine("Please Do Not Enter String Enter Numbers Only.");
}
// catch all other error and display it to user
catch (Exception ex)
{
    Console.WriteLine(ex);
}
// either user get error or not this will run
finally { 
    Console.ReadLine();
}