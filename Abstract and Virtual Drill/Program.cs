using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Virtual_Drill
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string Name = FirstName + " " + LastName;
            Console.WriteLine(Name);
        }
    }

    public class Employee : Person
    {

    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();

        }
    }
}
