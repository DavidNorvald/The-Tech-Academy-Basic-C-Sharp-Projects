using System;

namespace Interfaces_Drill
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string Name = FirstName + " " + LastName;
            Console.WriteLine(Name);
        }
    }

    interface IQuittable
    {
        void Quit(Employee employee);
    }

    public class Employee : Person, IQuittable
    {
        public void Quit(Employee employee)
        {
            Console.WriteLine("I Quit.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            employee.Quit(employee);
            Console.ReadLine();

        }
    }
}
