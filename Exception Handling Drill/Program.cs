using System;
using System.Collections.Generic;

namespace Exception_Handling_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryTimes = 0;
            while (tryTimes < 3)
            {
                try
                {
                    List<int> Numbers = new List<int>() { 12, 24, 35, 70, 55, 23, 8, 62 };
                    Console.WriteLine("Pick a number to divide by.");
                    int userNum = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in Numbers)
                    {
                        int dividedNum = number / userNum;
                        Console.WriteLine(number + " divided by " + userNum + " equals " + dividedNum);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Execution ran as normal");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number");
                    tryTimes++;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by zero.");
                    tryTimes++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryTimes++;
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
