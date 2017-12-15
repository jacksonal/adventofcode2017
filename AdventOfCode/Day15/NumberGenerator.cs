using System.Threading.Tasks;

namespace AdventOfCode.Day15
{
    public class NumberGenerator
    {
        private readonly int _divider = 2147483647;
        private int _factor;
        private long _previousValue;
        private int _multipleFilter;

        public NumberGenerator(int multiplicationFactor, long startValue, int multipleFilter = 1)
        {
            _factor = multiplicationFactor;
            _previousValue = startValue;
            _multipleFilter = multipleFilter;
        }

        public Task<long> Next()
        {
            return Task.Factory.StartNew(() =>
            {
                do
                {
                    _previousValue = (_previousValue * _factor) % _divider;
                } while (_previousValue % _multipleFilter != 0);
                return _previousValue;
            });
        }
    }
}