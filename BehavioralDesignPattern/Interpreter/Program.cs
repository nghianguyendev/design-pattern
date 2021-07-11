using System;

namespace Interpreter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Interpreter design pattern!");

            var context = new Context
            {
                date = DateTime.Now,
                expression = "DD/MM/YYYY"
            };

            var yearExpression = new YearExpression();
            var monthExpression = new MonthExpression();
            var dayExpression = new DayExpression();

            yearExpression.Evaluate(context);
            monthExpression.Evaluate(context);
            dayExpression.Evaluate(context);

            Console.WriteLine(context.expression);
        }
    }
}