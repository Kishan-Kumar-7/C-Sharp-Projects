using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssigment
{
    public class math2
    {
        //this mathod will take integer and return integer
        public static int Multi(int x) { 
            return x*7;
        }
        // this mathod will take decimal and return integer
        public static int Multi(decimal x) { 
            return Convert.ToInt32(x*7);
        }
        public static int Multi(string x) { 
            int y = Convert.ToInt32(x);
            return y*7;
        }
    }
}
