// using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Challeges
{
    class Week1Challenge
    {
        static void Main(string[] args)
        {
            // Delare and initalize variables that hold your first name, last name, and age

            string firstName = "Jamie";
            string lastName = "Hill";
            int age = 44;


            /// Declare and initalixe an array that holds a collection of at lease four of your favorite books or movie titles
            
            string[] books = { "Count of Monte Cristo", "Extreme Ownership", "The Secret", "7 Habits" };
            string[] movies = { "Count of Monte Cristo", "Star Wars", "The Hobit", "Underworld: The Rise of Likens" };


            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);

            }

            // How to display by the array [0]

            DateTime now = DateTime.Now;
            string b = now.ToString();

            // Make a list that hold dates. Include on that list the current date and time.

            List<string> Names = new List<string>();
            Names.Add("Jamie");
            Names.Add("Calvin");
            Names.Add("Michael");
            Names.Add("Anthony");
            Names.Add(b);
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }

            // write out to console the value  calculated by your age variable and the number 7. Use each operator we covered in Operators.


            int sum = age + 7;
            Console.WriteLine(sum);
            int diff = age - 7;
            Console.WriteLine(diff);
            int prod = age * 7;
            Console.WriteLine(prod);
            int quot = age / 7;
            Console.WriteLine(quot);
            int remainder = age % 7;
            Console.WriteLine(remainder);

            //// Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            ////If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
            ////If the hours is greater than 8 but less than 10, write to the console "You should be pretty rested"
            ////If the hours is greater than 4 but less than 8, output "Bummer"
            ////For any other condition output "Oh man, get some sleep!"

            int hoursOfSleep = 4;

            if (hoursOfSleep > 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!"); } 


                    else if (8 < hoursOfSleep && hoursOfSleep < 10)
                {

                    Console.WriteLine("You should be pretty rested");
                }

                else if (8 > hoursOfSleep  && hoursOfSleep > 4)
                {

                    Console.WriteLine("Bummer!");
                }

            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            //    // Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.


            string usersDay = "Great";
            switch (usersDay)
            {
                case "Great":
                    {
                    Console.WriteLine("That's awesome! You had a greate day");

                    }

                    break;

                case "Goodt":
                    {

                    Console.WriteLine("Nice! You had a good day");
                    }

                    break;

                case "Okay":
                    {

                        Console.WriteLine(" You had a okay day");
                    }

                    break;

                case "Bad":
                    {

                        Console.WriteLine("Well, lets focus on the positive and make it better.");
                    }

                    break;

                    Console.ReadKey();

            }

        }

    }

