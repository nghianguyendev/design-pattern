using SOLID.InterfaceSegregationPrinciple;

using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var photocopier = new Photocopier();
            photocopier.Print(new Document());
        }
    }
}
