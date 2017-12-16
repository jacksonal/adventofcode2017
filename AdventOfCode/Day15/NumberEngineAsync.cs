using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdventOfCode.Day15
{
    public class NumberEngineAsync : NumberEngine
    {
        private object _lockObj;
        private Queue<long> _qA;
        private Queue<long> _qB;
        private bool _isDone;

        public NumberEngineAsync(long aStart, long bStart) : base(aStart, bStart)
        {
            Reset();
        }

        public NumberEngineAsync(int aStart, int bStart, int aFilter, int bFilter) : base(aStart, bStart, aFilter, bFilter)
        {
            Reset();
        }

        public void Reset()
        {
            _lockObj = new Object();
            _qA = new Queue<long>();
            _qB = new Queue<long>();
            _isDone = false;

        }
        public int GetCountOfValidNumbersGeneratedAsync(long pairsToCheck)
        {
            var pairsChecked = 0;
            
            Task.Factory.StartNew(() =>
            {
                GenerateNumbers(_qA);
            });
            Task.Factory.StartNew(() => { GenerateNumbers(_qB); });

            while (pairsChecked < pairsToCheck)
            {
                lock (_lockObj)
                {
                    if (_qA.Count > 0 && _qB.Count > 0)
                    {
                        _judge.Compare(_qA.Dequeue(), _qB.Dequeue());
                        pairsChecked++;
                    }
                }
            }
            _isDone = true;
            return _judge.ValidCount;
        }

        private void GenerateNumbers(Queue<long> q)
        {
            while (!_isDone)
            {
                lock (_lockObj)
                {
                    if (q.Count < 10000)
                    {
                        for (int i = 0; i < 100000; i++)
                            q.Enqueue(_generatorB.Next());
                    }
                }
            }
        }
    }
}