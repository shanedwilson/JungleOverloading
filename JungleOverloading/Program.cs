using System;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee shane = new Employee("Shane", "Wilson");
            Employee stacye = new Employee("Stacye", "Wilson");
            Employee nazz = new Employee("Nazz", "Wilson");
            Employee jamie = new Employee("Jamie", "Vosmeier");
            Employee sgt = new Employee("Sgt.", "Pepper");

            stacye.eat();
            stacye.eat("something delicious");
        }
    }
}
