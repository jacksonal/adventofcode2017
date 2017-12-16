namespace AdventOfCode.Day15
{
    public class NumberEngine
    {
        protected NumberJudge _judge;
        protected NumberGenerator _generatorA;
        protected NumberGenerator _generatorB;

        public NumberEngine(long aStart, long bStart)
        {
            _judge = new NumberJudge();
            _generatorA = new NumberGenerator(16807,aStart);
            _generatorB = new NumberGenerator(48271, bStart);
        }

        public NumberEngine(int aStart, int bStart, int aFilter, int bFilter)
        {
            _judge = new NumberJudge();
            _generatorA = new NumberGenerator(16807, aStart, aFilter);
            _generatorB = new NumberGenerator(48271, bStart, bFilter);
        }

        public int GetCountOfValidNumbersGenerated(long pairsToCheck)
        {
            for (var i = 0; i < pairsToCheck; i++)
            {
                _judge.Compare(_generatorA.Next(), _generatorB.Next());
            }
            return _judge.ValidCount;
        }
    }
}