using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class Removed
    {
        public void Special()
        {
            Console.WriteLine(remove_char("Ritesh" ,1));
            Console.WriteLine(remove_char("Ritesh",4));
            Console.WriteLine(remove_char("Ritesh", 0));
        }
        public static string remove_char(string str,int n)
        {
            return str.Remove(n,1);
        }
    }
}
