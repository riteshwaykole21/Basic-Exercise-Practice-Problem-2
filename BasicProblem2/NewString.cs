using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class NewString
    {
        public void Crete()
        {
            string str;
            Console.WriteLine("Input a string :");
            str = Console.ReadLine();
            if(str.Length>=1)
            {
                var S = str.Substring(0 ,1);
                Console.WriteLine(S + str + S);
            }
        }
            
    }
}
