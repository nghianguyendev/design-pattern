using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Iterator Design Pattern!");

            var week = new Week();
            var weekDaysIterator = week.GetWeekDaysEnumerator();

            while (weekDaysIterator.MoveNext())
            {
                Console.WriteLine(weekDaysIterator.Current);
            }
            Console.WriteLine();
            foreach (var day in week.GetWeekDaysEnumerable())
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();
            foreach (var day in week.GetWeekWorkingDaysEnumerable())
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("--Using Yield--");
            var week1 = new IteratorWithYield.Week();
            var weekDaysIterator1 = week1.GetWeekDaysEnumerator();

            while (weekDaysIterator1.MoveNext())
            {
                Console.WriteLine(weekDaysIterator1.Current);
            }

            foreach (var day in week1.GetWeekDaysEnumerable())
            {
                Console.WriteLine(day);
            }

            Console.ReadLine();
        }
    }
}
