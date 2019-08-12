using System;

namespace Method_Decimal_Drill
{
    public class Math_Method
    {
        public static void Sum(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"Addition result is: {result}");     // $ represents text as UTF-16 chars when displayed to console
        }

        public static void Subtract(double num1, double num2)     //
        {
            double result = num1 - num2;
            Console.WriteLine($"Substraction result is: {result}");     // $ represents text as UTF-16 chars when displayed to console
        }

        public static void Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine($"Multiplication result is: {result}");       // $ represents text as UTF-16 chars when displayed to console
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lets do some Math.");
            Console.WriteLine("What number would you like to do some math operations on?");     //input for int
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lets add " + firstNum + " to the number 12 and see what we get.");
            Math_Method.Sum(firstNum, 12);
            Console.ReadLine();


            Console.WriteLine("Now enter a decimal number.");     // input for decimal
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lets subtract " + secondNum + " from 12 and see what we get.");
            Math_Method.Subtract(secondNum, 12);
            Console.ReadLine();


            Console.WriteLine("Now, give me one last number.");     // takes input as a string
            string thirdString =  Console.ReadLine();
            int thirdNum = Convert.ToInt32(thirdString);        //converts the number as a string to an int

            Console.WriteLine("Lets multiply " + thirdNum + " by 12 and see what we get.");
            Math_Method.Multiplication(thirdNum, 12);
            Console.ReadLine();




        }


    }
}
