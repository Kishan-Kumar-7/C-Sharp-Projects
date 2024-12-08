using ClassMethod;

Console.WriteLine("Plese Enter a Number Your Want To Devide By 2 :");
int val1 = Convert.ToInt32(Console.ReadLine());
// parsing value to class method for devision and result will be store in variable
int res = Calcu.Devi(val1);
Console.WriteLine("You Have Entered {0} and it's Devided By 2.\nYour Answer is :{1}",val1,res);