using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class Positions
    {
        public void Create()
        {
            Console.WriteLine(first_last("w3resources"));
            Console.WriteLine(first_last("Pyton"));
            Console.WriteLine(first_last("x"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1 , ustr.Length - 2) + ustr.Substring(0 ,1) : ustr;  
        }
    }
}
