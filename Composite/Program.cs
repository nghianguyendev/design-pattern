using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Composite Design pattern!");

            var manager = new CoreEmployee { Name = "Manager" };
            var teamleader = new CoreEmployee { Name = "Team Lead" };
            var member1 = new CoreEmployee { Name = "Member1" };
            var member2 = new CoreEmployee { Name = "Member2" };
            var contract = new ContractEmployee { Name = "Contract" };

            teamleader.Add(member1);
            teamleader.Add(member2);
            member2.Add(contract);

            manager.Add(teamleader);

            EmployeeExtension.PrintHierarchy(manager);
        }
    }

    public static class EmployeeExtension
    {
        public static void PrintHierarchy(this CoreEmployee employee)
        {
            foreach (CoreEmployee item in employee)
            {
                Console.WriteLine($"{item.Name}");
                foreach (CoreEmployee item1 in item)
                {
                    Console.WriteLine($"  {item1.Name}");
                    foreach (ContractEmployee item2 in item1)
                    {
                        Console.WriteLine($"    {item2.Name}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
