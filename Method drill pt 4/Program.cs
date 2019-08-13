using System;

namespace Method_drill_pt_4
{
    public class Math_Method
    {
        public static void Sum(int num1, int? num2, int num3)
        {
            int? result = num1 + num2 + num3;
            Console.WriteLine($"Addition result is: {result}");     // $ represents text as UTF-16 chars when displayed to console
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Lets do some Math.");
            Console.WriteLine("What number would you like to do some math operations on?");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("For the second number, you do not need to enter anything at all if you choose.");     // allows for another user input if desired
                string numNull = Console.ReadLine();
                bool n1 = string.IsNullOrWhiteSpace(numNull);

                if (n1 == true)
                {
                    int secondNum = 0;
                    Math_Method.Sum(firstNum, secondNum, 4);
                    Console.WriteLine("There was no additional input number.");
                }
                if (n1 == false)
                {
                    int secondNum = Convert.ToInt32(numNull);
                    Math_Method.Sum(firstNum, secondNum, 4);
                    Console.WriteLine("Not null value input field");

                }
                Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Whoops");
            }
        }
    }
}
