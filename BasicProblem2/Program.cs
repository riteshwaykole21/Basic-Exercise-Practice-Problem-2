using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Takes an Age");
            Console.WriteLine("2 : Enter Any Number");
            Console.WriteLine("Enter a Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Age age = new Age();
                    age.AgeExa();
                    break;
                case 2:
                    Row row = new Row();
                    row.RowEx();
                    break;
            }
            Console.ReadLine();
        }
    }
}
