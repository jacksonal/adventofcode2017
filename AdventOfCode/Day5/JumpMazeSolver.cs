namespace AdventOfCode.Day5
{
    public class JumpMazeSolver : JumpMazeSolverBase
    {
        public JumpMazeSolver(string maze) : base(maze)
        {
        }

        public override void Jump()
        {
            CurrentIndex += Maze[CurrentIndex]++;
        }
    }
}