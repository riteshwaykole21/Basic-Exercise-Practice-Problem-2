﻿using System;
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
            Console.WriteLine("3 : Enter A Number");
            Console.WriteLine("4 :  Enter The celsius");
            Console.WriteLine("5 : Remove Special Character ");
            Console.WriteLine("6 : Change Their Position");
            Console.WriteLine("7 : To create New String From Given String");
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
                case 3 :
                    Columns columns = new Columns();
                    columns.Rows();
                    break;
                case 4:
                    Converts converts = new Converts();
                    converts.celsius();
                    break;
                case 5:
                    Removed remove = new Removed();
                    remove.Special();
                    break;
                case 6:
                    Positions positions = new Positions();
                    positions.Create();
                    break;
                case 7:
                    NewString newString = new NewString();
                    newString.Crete();
                    break;
            }
            Console.ReadLine();
        }
    }
}
