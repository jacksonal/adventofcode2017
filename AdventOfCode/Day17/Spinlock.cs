using System.Collections.Generic;

namespace AdventOfCode.Day17
{
    public class Spinlock
    {
        private int _currentPos;
        private List<long> _values;
        private int _steps;

        public int CurrentPosition => _currentPos;

        public Spinlock(int steps)
        {
            _currentPos = 0;
            _steps = steps;
            _values = new List<long>{0};
        }

        public void BuildValues(long insertions)
        {
            for (var i = 0; i < insertions; i++)
            {
                _currentPos = ((_currentPos + _steps) % (i + 1)) + 1;
                _values.Insert(_currentPos, i + 1);
            }
        }

        public long GetValue(int index)
        {
            return _values[index];
        }

        public long GetValueAfterInsertions(int index, long insertions)
        {
            var ret = 0;
            for (var i = 0; i < insertions; i++)
            {
                _currentPos = ((_currentPos + _steps) % (i+1)) + 1;
                if (_currentPos == index)
                {
                    ret = i + 1;
                }
            }
            return ret;
        }
    }
}