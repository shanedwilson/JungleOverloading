using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        static Random rnd = new Random();

        static List<string> restaurants = new List<string>
        {
            "Jay's",
            "Taj",
            "Hugh Baby",
            "El Fuego",
            "House Of Kabob"
        };

        //public void AddEmployee(Employee employee)
        //{
        //    Employees.Add(employee);
        //}

        public int generateRandomNum()
        {
            // creates a number between 1 and the length of the list
            int randNum = rnd.Next(1, restaurants.Count);
            return randNum;
        }

        public void Eat()
        {
            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurants[generateRandomNum()]}.");
            Console.ReadKey();
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
            Console.ReadKey();
        }

        public void Eat(List<Employee> buddies)
        {
            string diningPals = "";
            for(int i = 0; i < buddies.Count; i++)
            {
                if (buddies[i].FirstName != FirstName)
                {
                    if (i != buddies.Count - 1)
                    {
                       diningPals += buddies[i].FirstName + ",";
                    } else
                    {
                        diningPals += "and " + buddies[i].FirstName;
                    }
                }
            }
            Console.WriteLine($"{FirstName} is eating at {restaurants[generateRandomNum()]} with {diningPals}.");
            Console.ReadKey();
        }

        public void Eat(string food, List<Employee> buddies)
        {
            string diningPals = "";
            for (int i = 0; i < buddies.Count; i++)
            {
                if (buddies[i].FirstName != FirstName)
                {
                    if (i != buddies.Count - 1)
                    {
                        diningPals += buddies[i].FirstName + ",";
                    }
                    else
                    {
                        diningPals += "and " + buddies[i].FirstName;
                    }
                }
            }
            Console.WriteLine($"{FirstName} is eating {food} at {restaurants[generateRandomNum()]} with {diningPals}.");
            Console.ReadKey();
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
