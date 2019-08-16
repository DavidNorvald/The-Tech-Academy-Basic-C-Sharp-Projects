using System;

namespace Structs_Drill
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.14m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
