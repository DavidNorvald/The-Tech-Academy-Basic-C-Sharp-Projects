using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Function_Drill
{


    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

    }



    class Program
    {

        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 1, firstName = "Joe", lastName = "Smith" });
            empList.Add(new Employee() { ID = 2, firstName = "Adam", lastName = "Jones" });
            empList.Add(new Employee() { ID = 3, firstName = "Dave", lastName = "Grimes" });
            empList.Add(new Employee() { ID = 4, firstName = "John", lastName = "Weave" });
            empList.Add(new Employee() { ID = 5, firstName = "Ben", lastName = "Harsh" });
            empList.Add(new Employee() { ID = 6, firstName = "Mark", lastName = "Savage" });
            empList.Add(new Employee() { ID = 7, firstName = "Jerry", lastName = "Sparks" });
            empList.Add(new Employee() { ID = 8, firstName = "Linda", lastName = "Lang" });
            empList.Add(new Employee() { ID = 9, firstName = "Helen", lastName = "Chase" });
            empList.Add(new Employee() { ID = 10, firstName = "Joe", lastName = "Longe" });

            // List of Employees named Joe
            foreach (Employee employee in empList)
            {
                List<Employee> newList = new List<Employee>();      // Creates newList to add employees to from filtering
                if (employee.firstName == "Joe")        // filters empList for employees named Joe
                {
                    newList.Add(employee);      // Adds employees named Joe to NewList
                    Console.WriteLine("{0} {1} {2}", employee.ID, employee.firstName, employee.lastName);       // Prints newList employees added to list
                }
            }
            Console.ReadLine();

            // List of employees names Joe using lambda
            List<Employee> newList2 = empList.Where(x => x.firstName.Contains("Joe")).ToList();         // filters empList for employees named Joe
            foreach (Employee employee in newList2)         
            {
                Console.WriteLine("{0} {1} {2}", employee.ID, employee.firstName, employee.lastName);       // Prints newList employees added to list
            }
            Console.ReadLine();


            // List of all employees with ID greater than 5
            List<Employee> newList3 = empList.Where(x => x.ID > 5).ToList();        // filters empList for employees with ID's greater than 5
            foreach (Employee employee in newList3)
            {
                Console.WriteLine("{0} {1} {2}", employee.ID, employee.firstName, employee.lastName);       // Prints newList employees added to list
            }
            Console.ReadLine();


        }
    }
}
