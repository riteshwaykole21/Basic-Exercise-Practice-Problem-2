﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem2
{
    public class Converts
    {
        public void celsius()
        {
            Console.WriteLine("Enter The Amount of celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}" ,celsius + 273);
            Console.WriteLine("Fahrenheit = {0}" , celsius * 18/10 +32);

        }
    }
}
