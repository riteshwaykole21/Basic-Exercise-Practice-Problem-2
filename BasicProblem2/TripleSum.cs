using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class TripleSum
    {
        public void Sum()
        {
            Console.WriteLine("Enter The First Number ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine()); 
            int result = FirstNumber + SecondNumber;
            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine(result*3);
            }
            else
            {
                Console.WriteLine("The values Are Not Same ");
            }    
        }
    }
}
