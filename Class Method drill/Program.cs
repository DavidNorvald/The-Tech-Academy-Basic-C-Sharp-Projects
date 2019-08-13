using System;

namespace Class_Method_drill
{
    class divideNum
    {
        public void Divide(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine($"Division result is: {result}");     // $ represents text as UTF-16 chars when displayed to console
        }

        public static void Divide()
        {
            int result = 2 / 1;
            Console.WriteLine($"Division result is: {result}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            divideNum divide = new divideNum();

            Console.WriteLine("Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            divide.Divide(userNum);
            Console.ReadLine();
        }
    }
}
