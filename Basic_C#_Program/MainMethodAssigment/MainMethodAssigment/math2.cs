using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssigment
{
    public class math2
    {
        //this method will take integer and return integer
        public static int Multi(int x) { 
            return x*7;
        }
        // this method will take decimal and return integer
        public static int Multi(decimal x) { 
            return Convert.ToInt32(x*7);
        }
        // this method will take string and return integer
        public static int Multi(string x) { 
            int y = Convert.ToInt32(x);
            return y*7;
        }

        // this method can work with two perameter one of them is optional
        public static int opti(int x, int y = 1) {
            return x * y;
        }
    }
}
