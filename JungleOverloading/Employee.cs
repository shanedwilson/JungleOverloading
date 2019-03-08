using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        static List<string> restaurants = new List<string>
        {
            "Jay's",
            "Taj",
            "Hugh Baby",
            "El Fuego",
            "House Of Kabob"
        };

        public void eat()
        {
            Random rnd = new Random();
            int randNum = rnd.Next(1, restaurants.Count);   // creates a number between 1 and the length of the list

            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurants[randNum]}.");
            Console.ReadKey();
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
            Console.ReadKey();
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
