using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class Row
    {
        public void RowEx()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.Write(Number);
            Console.Write(" ");
            Console.Write(Number);
            Console.Write(" ");
            Console.Write(Number);
            Console.Write(" ");
            Console.WriteLine(Number);
            Console.WriteLine("----------------");
            Console.Write(Number);
            Console.Write(Number);
            Console.Write(Number);
            Console.WriteLine(Number);
            Console.WriteLine("-----------------");
            Console.WriteLine("{0} {0} {0} {0}",Number);
            Console.WriteLine("--------------------");
            Console.WriteLine("{0}{0}{0}{0}", Number);

        }
    }
}
