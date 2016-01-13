using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Borislav";
            string middleName = "Valeriev";
            string lastName = "Gotsev";
            decimal balance = 450389.32m;
            string bankName = "DSK Bank";
            string IBAN = "BG32 UBBS 7827 1013 6179 05";
            long cardNumber1 = 4147205963269586;
            long cardNumber2 = 5466168956963236;
            long cardNumber3 = 4658459656233352;


            Console.WriteLine("        Welcome \n{0} {1} {2} \n" +
                "Your Balance is: {3} leva\nBank: {4}\nIBAN: {5}\n" + 
                "Card Number: {6}\nCard Number: {7}\nCard Number: {8}",
                firstName, middleName , lastName , balance, 
                bankName, IBAN, cardNumber1, cardNumber2, cardNumber3
                );
        }
    }
}
