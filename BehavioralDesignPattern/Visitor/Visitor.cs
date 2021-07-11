using System;

namespace Visitor
{
    internal abstract class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        /// <summary>
        /// Double dispatch: a strict that allows dynamic binding alongside with overload methods
        /// 
        /// The `accept` method is overriden, not overloaded. Compiler binds it
        /// dynamically. Therefore the `accept` will be executed on a class that
        /// corresponds to an object calling a method (in our case, the `Dot` class).
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(IExportVisitor visitor);
    }

    internal class VietnamEmployee : Employee
    {
        public VietnamEmployee(string name, int salary) : base(name, salary)
        {
        }

        public override void Accept(IExportVisitor visitor)
        {
            visitor.Export(this);
        }
    }

    internal class SwissEmployee : Employee
    {
        public SwissEmployee(string name, int salary) : base(name, salary)
        {
        }
        public override void Accept(IExportVisitor visitor)
        {
            visitor.Export(this);
        }
    }

    internal class EgyptEmployee : Employee
    {
        public EgyptEmployee(string name, int salary) : base(name, salary)
        {
        }

        public override void Accept(IExportVisitor visitor)
        {
            visitor.Export(this);
        }
    }

    internal interface IExportVisitor
    {
        void Export(VietnamEmployee vietnamEmployee);
        void Export(SwissEmployee swissEmployee);
        void Export(EgyptEmployee egyptEmployee);
    }

    class ExportVisitor : IExportVisitor
    {
        public void Export(VietnamEmployee employee)
        {
            Console.WriteLine($"Vietnam salary of {employee.Name} is {employee.Salary}");
        }

        public void Export(SwissEmployee employee)
        {
            Console.WriteLine($"Swiss salary of {employee.Name} is {employee.Salary}");
        }

        public void Export(EgyptEmployee employee)
        {
            Console.WriteLine($"Egypt salary of {employee.Name} is {employee.Salary}");
        }
    }
}