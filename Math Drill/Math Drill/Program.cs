using System;

namespace Math_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Input a whole number.");
            string myNumber = Console.ReadLine();
            double numberIs = Convert.ToInt32(myNumber);
            Console.WriteLine(numberIs + " multiplied by 50 is: " + numberIs * 50);
            Console.ReadLine();

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Input another whole number.");
            string numAdd = Console.ReadLine();
            int theNumber = Convert.ToInt32(numAdd);
            int plus25 = 25;
            int totalAdd = theNumber + plus25;
            Console.WriteLine(theNumber + " plus 25 is: " + totalAdd);
            Console.ReadLine();

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("What number will you enter next?");
            string numDivide = Console.ReadLine();
            int inputNum = Convert.ToInt32(numDivide);
            float dividedBy = 12.5f;
            float totalDivide = inputNum / dividedBy;
            Console.WriteLine(inputNum + " divided by 12.5 is: " + totalDivide);
            Console.ReadLine();

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("It's 50 degrees outside, what is the temperature inside your house?.");
            string tempInput = Console.ReadLine();
            int insideTemp = Convert.ToInt32(tempInput);
            int outsideTemp = 50;
            bool whatIsTheTemp = insideTemp > outsideTemp;
            Console.WriteLine("Is the temperature inside your house warmer than outside?: " + whatIsTheTemp);
            Console.ReadLine();

            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.WriteLine("Does your number have a remainder? Input a whole number.");
            string  numRemainder= Console.ReadLine();
            int num1 = Convert.ToInt32(numRemainder);
            int num2 = 7;
            int remainder = num1 % num2;
            Console.WriteLine("The remainder of " + numRemainder + " is: " + remainder);
            Console.ReadLine();

        }
    }
}