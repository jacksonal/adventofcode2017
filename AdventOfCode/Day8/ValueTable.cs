using System.Collections.Generic;

namespace AdventOfCode.Day8
{
    public class ValueTable
    {
        private Dictionary<string, int> _table = new Dictionary<string, int>();

        public IEnumerable<int> Values
        {
            get { return _table.Values; }
        }

        public int LookUp(string symbol)
        {
            symbol = symbol.Trim();
            if (!_table.ContainsKey(symbol))
            {
                _table.Add(symbol, 0);
            }
            return _table[symbol];
        }

        public void Update(string symbol, int value)
        {
            _table[symbol] = value;
        }
    }
}