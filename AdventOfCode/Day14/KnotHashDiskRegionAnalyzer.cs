using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day14
{
    public class KnotHashDiskRegionAnalyzer : KnotHashDiskAnalyzer
    {
        private string[] _dotMatrix;
        private int[][] _regionMatrix;
        private int _currentGroupCount;
        public KnotHashDiskRegionAnalyzer()
        {
            _dotMatrix = new string[128];
            _regionMatrix = new int[128][];
            for (int i = 0; i < _dotMatrix.Length; i++)
            {
                _regionMatrix[i] = new int[128];
            }
        }

        public override int Solve(string input)
        {
            BuildDotMatrix(input);
            BuildCountMatrix();
            return _currentGroupCount;
        }

        private void BuildCountMatrix()
        {
            for (int i = 0; i < _dotMatrix.Length; i++)
            {
                for (int j = 0; j < _dotMatrix.Length; j++)
                {
                    DetermineGrouping(i, j);
                }
            }
        }

        private void DetermineGrouping(int i, int j)
        {
            if (i >= 0 && i <= 127 && j >= 0 && j <= 127)
            {
                if (_dotMatrix[i][j] == '1' && _regionMatrix[i][j] == 0)
                {
                    var region = GetConnectedRegion(i, j);
                    if (region != 0)
                    {
                        _regionMatrix[i][j] = region;
                    }
                    else
                    {
                        _regionMatrix[i][j] = ++_currentGroupCount;
                    }

                    if (i - 1 >= 0)
                    {
                        DetermineGrouping(i - 1,j);
                    }
                    if (i + 1 <= 127)
                    {
                        DetermineGrouping(i + 1, j);
                    }
                    if (j - 1 >= 0)
                    {
                        DetermineGrouping(i, j-1);
                    }
                    if (j + 1 <= 127)
                    {
                        DetermineGrouping(i, j+1);
                    }
                }
            }
        }

        private int GetConnectedRegion(int i, int j)
        {
            var connected = new List<int>();
            if (i - 1 >= 0)
            {
                connected.Add(_regionMatrix[i - 1][j]);
            }
            if (i + 1 <= 127)
            {
                connected.Add(_regionMatrix[i + 1][j]);
            }
            if (j - 1 >= 0)
            {
                connected.Add(_regionMatrix[i][j - 1]);
            }
            if (j + 1 <= 127)
            {
                connected.Add(_regionMatrix[i][j + 1]);
            }
            return connected.Max();
        }

        private void BuildDotMatrix(string input)
        {
            for (int i = 0; i < 128; i++)
            {
                _dotMatrix[i] = GetHashAsBinary($"{input}-{i}");
                _hashSolver.Reset();
            }
        }
    }
}