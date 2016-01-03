using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort firstNumber = 52130;
            sbyte secondNumber = -115;
            int thirdNumber = 4825932;
            sbyte fourthNumber = 97;
            short fifthNumber = 10000;


            Console.WriteLine
                ("First number: {0}\nSecond number: {1}\nThird number: {2}\nFourth number: {3}\nFifth number: {4}", 
                firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
    }
}