using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class Columns
    {
        public void Rows()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}",Number);
            Console.WriteLine("{0} {0}",Number);
            Console.WriteLine("{0} {0}", Number);
            Console.WriteLine("{0} {0}", Number);
            Console.WriteLine("{0}{0}{0}", Number);
        }
    }
}
