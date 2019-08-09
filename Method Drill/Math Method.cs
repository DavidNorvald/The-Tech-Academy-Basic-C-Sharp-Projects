using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill
{
    public class Math_Method
    {
        public static void Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"Addition result is: {result}");     // $ represents text as UTF-16 chars when displayed to console
        }

        public static void Subtract(int num1, int num2)     //
        {
            int result = num1 - num2;
            Console.WriteLine($"Substraction result is: {result}");     // $ represents text as UTF-16 chars when displayed to console
        }

        public static void Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"Multiplication result is: {result}");       // $ represents text as UTF-16 chars when displayed to console
        }



    }
}
