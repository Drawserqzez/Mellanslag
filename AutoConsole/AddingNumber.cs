using System.Collections.Generic;

namespace AutoConsole
{
    public class AddingNumber : ISubscriber
    {
        private List<int> _numbers;

        public AddingNumber()
        {
            _numbers = new List<int>();
        }

        public void Update()
        {
            if (_numbers.Count <= 31)
                { _numbers.Add(_numbers.Count + 1); }
        }

        public override string ToString()
        {
            string str = "Numbers in object: ";
            foreach (var number in _numbers)
            {
                str += $", {number}";
            }
            return str;
        }
    }
}