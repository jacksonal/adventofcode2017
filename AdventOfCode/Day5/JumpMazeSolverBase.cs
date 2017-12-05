using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day5
{
    public abstract class JumpMazeSolverBase
    {
        protected JumpMazeSolverBase(string maze)
        {
            Maze = maze.Split().Where(s => s != String.Empty).Select(s => Convert.ToInt32(s)).ToList();
            CurrentIndex = 0;
        }

        public List<int> Maze { get; set; }
        public int CurrentIndex { get; set; }
        public abstract void Jump();

        public int Solve()
        {
            var ret = 0;
            while (CurrentIndex < Maze.Count)
            {
                Jump();
                ret++;
            }
            return ret;
        }
    }
}