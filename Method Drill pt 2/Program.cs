using System;

namespace Method_Drill_pt_2
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




        static void Main(string[] args)
        {
            Console.WriteLine("Lets do some Math.");
            Console.WriteLine("What number would you like to do some math operations on?");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");     // allows for another user input if desired
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Math_Method.Sum(firstNum, secondNum);
            Math_Method.Subtract(firstNum, secondNum);
            Math_Method.Multiplication(firstNum, secondNum);
        }
    }
}
