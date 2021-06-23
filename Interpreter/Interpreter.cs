using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
        public DateTime date { get; set; }
        public string expression { get; set; }
    }

    public interface IDateExpression
    {
        void Evaluate(Context context);
    }

    public class YearExpression : IDateExpression
    {
        public void Evaluate(Context context)
        {
            context.expression = context.expression.Replace("YYYY", context.date.Year.ToString());
        }
    }

    public class MonthExpression : IDateExpression
    {
        public void Evaluate(Context context)
        {
            context.expression = context.expression.Replace("MM", context.date.Month.ToString());
        }
    }

    public class DayExpression : IDateExpression
    {
        public void Evaluate(Context context)
        {
            context.expression = context.expression.Replace("DD", context.date.Day.ToString());
        }
    }

}
