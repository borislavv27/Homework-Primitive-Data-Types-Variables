using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null;
            double? floatDouble = null;
            Console.WriteLine("Null value: ", nullableInteger);
            Console.WriteLine("Null value: ", floatDouble);

            nullableInteger += 7;
            floatDouble += 4.5;
            Console.WriteLine("Number + Null Value: ", nullableInteger);
            Console.WriteLine("Number + Null Value: ", floatDouble);


            nullableInteger = 7;
            floatDouble = 4.5;
            Console.WriteLine("Number value: " + nullableInteger);
            Console.WriteLine("Number value: " + floatDouble);


        }
    }
}
