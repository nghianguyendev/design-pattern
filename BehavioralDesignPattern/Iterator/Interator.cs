using System.Collections;

namespace Iterator
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
            return new WeekDaysIterator(days);
        }

        public IEnumerator GetWeekDaysEnumerator()
        {
            return new WeekDaysIterator(days);
        }

        public IEnumerable GetWeekWorkingDaysEnumerable()
        {
            return new WeekWorkingDaysIterator(days);
        }

        public IEnumerator GetWeekWorkingDaysEnumerator()
        {
            return new WeekWorkingDaysIterator(days);
        }
    }

    public class WeekDaysIterator : IEnumerator, IEnumerable
    {
        private int currentIndex = -1;
        private readonly string[] days;

        public WeekDaysIterator(string[] days)
        {
            this.days = days;
        }

        public object Current => this.days[currentIndex];

        public bool MoveNext()
        {
            return ++currentIndex < days.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }

    public class WeekWorkingDaysIterator : IEnumerator, IEnumerable
    {
        private int currentIndex = -1;
        private readonly string[] days;

        public WeekWorkingDaysIterator(string[] days)
        {
            this.days = days;
        }

        public object Current => this.days[currentIndex];

        public bool MoveNext()
        {
            return ++currentIndex < days.Length-2;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}