using System;

namespace Income_Comparison_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.ReadLine();
            Console.WriteLine("Person 1.");
            Console.WriteLine("What is your Hourly Rate?:");
            string person1Wage = Console.ReadLine();
            int p1Wage = Convert.ToInt32(person1Wage);
            Console.WriteLine("How many hours do you work per week?:");
            string person1Hours = Console.ReadLine();
            int p1Hours = Convert.ToInt32(person1Hours);
            int p1Salary = p1Wage * p1Hours;
            Console.WriteLine("OK, now person 2.");
            Console.WriteLine("What is your Hourly Rate?:");
            string person2Wage = Console.ReadLine();
            int p2Wage = Convert.ToInt32(person2Wage);
            Console.WriteLine("How many hours do you work per week?:");
            string person2Hours = Console.ReadLine();
            int p2Hours = Convert.ToInt32(person2Hours);
            int p2Salary = p2Wage * p2Hours;
            Console.WriteLine("Weekly salary of Person 1: $" + p1Salary);
            Console.WriteLine("");
            Console.WriteLine("Weekly salary of Person 2: $" + p2Salary);
            bool whoMakesMore = p1Salary > p2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + whoMakesMore);
            Console.ReadLine();
            

        }
    }
}
