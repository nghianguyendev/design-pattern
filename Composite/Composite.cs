using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public interface IEmployee
    {
        string Name { get; set; }
    }

    public class CoreEmployee : IEmployee, IEnumerable<IEmployee>
    {
        private List<IEmployee> _subOrdinates = new List<IEmployee>();
        public string Name { get; set; }

        public void Add(IEmployee employee)
        {
            _subOrdinates.Add(employee);
        }

        public IEnumerator<IEmployee> GetEnumerator()
        {
            return _subOrdinates.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _subOrdinates.GetEnumerator();
        }
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
    }
}