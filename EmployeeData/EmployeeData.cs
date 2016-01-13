using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            string gender = "f";
            long personalID = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\n"
                + "Personal ID: {4}\nUnique Employee Number: {5}"
                ,firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }
}
