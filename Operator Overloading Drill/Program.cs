using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Drill
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

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
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return Comparison(emp1, emp2) == 0;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return Comparison(emp1, emp2) != 0;
        }
        public override bool Equals(object obj)
        {

            if (!(obj is Employee)) return false;

            return this == (Employee)obj;

        }
        public static int Comparison(Employee emp1, Employee emp2)
        {
            if (emp1.ID < emp2.ID)

                return -1;

            else if (emp1.ID == emp2.ID)

                return 0;

            else if (emp1.ID > emp2.ID)

                return 1;

            return 0;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" , ID = 1};

            Employee employee2 = new Employee() { FirstName = "Another", LastName = "Student" , ID = 2};

            employee.SayName();
            employee2.SayName();
            Console.WriteLine(Employee.Equals(employee, employee2));
            //employee.Quit(employee);
            Console.ReadLine();

        }
    }
}
