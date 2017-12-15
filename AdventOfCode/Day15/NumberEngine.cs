using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdventOfCode.Day15
{
    public class NumberEngine
    {
        private NumberJudge _judge;
        private NumberGenerator _generatorA;
        private NumberGenerator _generatorB;

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
                Task<long>[] tasks = new Task<long>[] {_generatorA.Next(), _generatorB.Next()};
                Task.WaitAll(tasks);
                _judge.Compare(tasks[0].Result,tasks[1].Result);
            }
            return _judge.ValidCount;
        }
    }
}