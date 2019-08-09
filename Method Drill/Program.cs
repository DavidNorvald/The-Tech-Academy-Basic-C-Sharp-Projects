using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets do some Math.");
            Console.WriteLine("What number would you like to do some math operations on?");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Math_Method.Sum(firstNum, secondNum);
            Math_Method.Subtract(firstNum, secondNum);
            Math_Method.Multiplication(firstNum, secondNum);

            //Math_Method.Sum(firstNum, 4);
            //Math_Method.Subtract(firstNum, 4);
            //Math_Method.Multiplication(firstNum, 4);


        }
    }
}

