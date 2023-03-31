using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class CheckInteger
    {
        public void Checks()
        {
            Console.WriteLine("Enter First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber < 0)
            {
                Console.WriteLine(true);
            }
            else if (SecondNumber > 0)
            {
                Console.WriteLine(true);
            }
        }
    }
}
