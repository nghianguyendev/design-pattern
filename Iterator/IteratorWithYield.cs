using System;
using System.Collections;

namespace IteratorWithYield
{
    public class Week
    {
        private readonly string[] days = new string[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Sartuday",
            "Sunday"
        };

        public string[] Days => days;

        public IEnumerable GetWeekDaysEnumerable()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }

        public IEnumerator GetWeekDaysEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }

        public IEnumerable GetWeekWorkingDaysEnumerable()
        {
            for (int i = 0; i < days.Length - 2; i++)
            {
                yield return days[i];
            }
        }

        public IEnumerator GetWeekWorkingDaysEnumerator()
        {
            for (int i = 0; i < days.Length - 2; i++)
            {
                yield return days[i];
            }
        }
    }
}