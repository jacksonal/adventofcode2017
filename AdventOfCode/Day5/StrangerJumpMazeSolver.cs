namespace AdventOfCode.Day5
{
    public class StrangerJumpMazeSolver : JumpMazeSolverBase
    {
        public StrangerJumpMazeSolver(string maze) : base(maze)
        {
        }

        public override void Jump()
        {
            if (Maze[CurrentIndex] >= 3)
            {
                CurrentIndex += Maze[CurrentIndex]--;
            }
            else
            {
                CurrentIndex += Maze[CurrentIndex]++;
            }
        }
    }
}