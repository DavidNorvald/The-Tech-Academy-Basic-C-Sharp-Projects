using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Drill
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


    public class Employee<T> : Person       // Generic type using <T>
    {
        public List<T> Things { get; set; }        // Set generic type of <T> to list as "Things"
    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> Item = new Employee<string>();     // employee string "Things"
            Item.Things = new List<string>();
            Item.Things.Add("Computer");
            Item.Things.Add("Phone");
            Item.Things.Add("Stapler");
            Item.Things.Add("Pen");
            Employee<int> Amount = new Employee<int>();     // employee int "Things"
            Amount.Things = new List<int>();
            Amount.Things.Add(1);

            foreach (int amount in Amount.Things)
            {
                foreach (string item in Item.Things)
                {
                    Console.WriteLine(amount + " " + item);
                }
            }
            Console.ReadLine();
        }
    }
}
