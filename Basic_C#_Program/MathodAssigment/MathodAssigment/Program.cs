using System.Security.Cryptography.X509Certificates;

namespace MathodAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create program which take two parameter and return result base on selection
            int total = 0;
            Console.WriteLine("Here is some methods available for Math Operations.");
            Console.WriteLine("1. Addition \n2. Multiplication \n3. Division \n4. Modulus \n5.Percentage");
            Console.WriteLine("Please Enter Value1 :");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Value2 :");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Select the Math Operation No. :");
            int opera = Convert.ToInt32(Console.ReadLine());
            // checking math opration selection
            if (opera == 1)
            {
                 total = math.Addition(val1,val2);
            }
            else if (opera == 2)
            {
                 total = math.multi(val1, val2);
            }
            else if (opera == 3)
            {
                total = math.divi(val1, val2);
            }
            else if (opera == 4)
            {
                total = math.mod(val1, val2);
            }
            else if (opera == 5)
            {
                total = math.perc(val1, val2);
            }
            else 
            {
                Console.WriteLine("Please Enter Valid Opration Next Time....");            
            }
            Console.WriteLine("Your answer is :"+ total.ToString());
        }
        
    }
}