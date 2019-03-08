using System;
using System.Collections.Generic;


namespace JungleOverloading
{
    class Program
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();

        static void Main(string[] args)
        {

            Employee shane = new Employee("Shane", "Wilson");
            Employee stacye = new Employee("Stacye", "Wilson");
            Employee nazz = new Employee("Nazz", "Wilson");
            Employee jamie = new Employee("Jamie", "Vosmeier");
            Employee sgt = new Employee("Sgt.", "Pepper");

            Employees.Add(shane);
            Employees.Add(stacye);
            Employees.Add(nazz);
            Employees.Add(jamie);
            Employees.Add(sgt);

            stacye.Eat();
            stacye.Eat("something delicious");
            stacye.Eat(Employees);
            stacye.Eat("something delicious", Employees);

        }
    }
}
