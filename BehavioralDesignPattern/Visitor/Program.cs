using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Visitor design pattern!");

            var swissEmployee = new SwissEmployee("Nghia", 1000);
            var export = new ExportVisitor();
            export.Export(swissEmployee);

            var egyptEmployee = new EgyptEmployee("Sopanos", 1000);
            egyptEmployee.Accept(export);

            Console.ReadKey();
        }
    }
}
