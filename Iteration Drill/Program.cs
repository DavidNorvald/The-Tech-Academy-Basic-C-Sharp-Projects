using System;
using System.Collections.Generic;

namespace Iteration_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a one-dimensional Array of strings. Ask the user to input some text. 
            // Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            // Then create a loop that prints off each string in the Array on a separate line.
            string[] nameArray = { "dave", "john", "bob", "tiffany", "lilly", "betty" };
            Console.WriteLine("Add a last name to the Array.");
            string lastName = Console.ReadLine().ToLower();


            for (int i = 0; i < nameArray.Length; i++)    
            {
                Console.WriteLine("People in the Array: " + nameArray[i] + " " + lastName);


            }
            Console.ReadLine();

            //2.Create an infinite loop.
            Console.WriteLine("Guess a number between 0 and 5.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("You guessed the number 4. That is correct!");
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        break;
                }
            }

            //3.Fix the infinite loop so it will execute.
            Console.WriteLine("Guess a number between 0 and 5.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("You guessed the number 4. That is correct!");
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        break;
                }
                Console.ReadLine();
            }

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            int[] Scores = { 98, 99, 12, 74, 23, 99 };

            for (int i = 0; i < 6; i++)
            {
                if (Scores[i] < 85)
                {
                    Console.WriteLine("Failing test scores: " + Scores[i]);
                }
            }
            Console.ReadLine();


            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int[] Scores2 = { 98, 99, 12, 74, 23, 99, 85 };

            for (int i = 0; i <= 6; i++)
            {
                if (Scores2[i] <= 85)
                {
                    Console.WriteLine("Failing test scores: " + Scores2[i]);
                }
            }
            Console.ReadLine();


            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.
            // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            List<string> colorList = new List<string>
                {
                "red",
                "blue",
                "yellow",
                "green",
                "orange",
                "purple"
                };


            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
            Console.WriteLine("Pick a color.");
            string userColor = Console.ReadLine().ToLower();


            Console.WriteLine("\nThe index of the color " + userColor + " is: {0} ",
                colorList.IndexOf(userColor));
            Console.ReadLine();


            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> colorList = new List<string>
                {
                "red",
                "blue",
                "yellow",
                "green",
                "orange",
                "purple"
                };


            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
            Console.WriteLine("Pick a color.");
            string userColor = Console.ReadLine().ToLower();
            if (colorList.Contains(userColor) == false)
            {
                Console.WriteLine("Color not in List");
            }
            else
            {
                Console.WriteLine("\nThe index of the color " + userColor + " is: {0} ",
                colorList.IndexOf(userColor));
            }

            Console.ReadLine();

            //8.Add code to that above loop that stops it from executing once a match has been found.
            List<string> colorList = new List<string>
                {
                "red",
                "blue",
                "yellow",
                "green",
                "orange",
                "purple"
                };


            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
            Console.WriteLine("Pick a color.");
            string userColor = Console.ReadLine().ToLower();
            if (colorList.Contains(userColor) == false)
            {
                Console.WriteLine("Color not in List");
            }
            else
            {
                Console.WriteLine("\nThe index of the color " + userColor + " is: {0} ",
                colorList.IndexOf(userColor));
            }

            Console.ReadLine();

            //9.Create a List of strings that has at least two identical strings in the List. 
            // Ask the user to select text to search for in the List.
            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            List<string> animals = new List<string>
            {
                "dog",
                "cat",
                "chicken",
                "fox",
                "rabbit",
                "dog",
                "turtle"
            };
            Console.WriteLine();
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            Console.WriteLine("Pick an animal.");
            Console.WriteLine();
            string UserAnimal = Console.ReadLine().ToLower();
            Console.WriteLine("\nThe index of " + UserAnimal + " is: {0}",
            animals.IndexOf(UserAnimal));

            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> animals = new List<string>
            {
                "dog",
                "cat",
                "chicken",
                "fox",
                "rabbit",
                "dog",
                "turtle"
            };
            Console.WriteLine();
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            Console.WriteLine("Pick an animal.");
            Console.WriteLine();
            string UserAnimal = Console.ReadLine().ToLower();
            if (animals.Contains(UserAnimal) == false)
            {
                Console.WriteLine("Animal not in the List.");
            }
            else
            {
                Console.WriteLine("\nThe index of " + UserAnimal + " is: {0}",
                    animals.IndexOf(UserAnimal));
            }
            Console.ReadLine();



            //11.Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> animals2 = new List<string>
            {
                "dog",
                "cat",
                "chicken",
                "fox",
                "rabbit",
                "dog",
                "turtle"
            };
            var myList = new List<string>();
            var duplicates = new List<string>();
            foreach (var animal2 in animals2)
            {
                if (!myList.Contains(animal2))
                    myList.Add(animal2);
                else
                    duplicates.Add(animal2);
            }

            // show list without duplicates
            foreach (var animal2 in myList)
                Console.WriteLine("Animals in List: " + animal2);
            Console.WriteLine();


            // show duplicates list
            foreach (var animal2 in duplicates)
                Console.WriteLine("Duplicates: " + animal2);
            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
