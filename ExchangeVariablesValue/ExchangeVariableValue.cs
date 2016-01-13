using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariablesValue
{
    class ExchangeVariableValue
    {
        static void Main(string[] args)
        {
            int variableA = 5;
            int variableB = 10;
            Console.WriteLine("Before\n" + variableA);
            Console.WriteLine(variableB);

            int variableC = variableA;
            variableA = variableB;
            variableB = variableC;

            Console.WriteLine("After\n" + variableA);
            Console.WriteLine(variableB);



        }
    }
}
