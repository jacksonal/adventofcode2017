using System.IO;

namespace AdventOfCode.Day8
{
    public class RegisterInstructionsMaxEverSolver : RegisterInstructionsSolver
    {
        public override int Solve(string input)
        {
            var max = int.MinValue;
            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    var tokens = line.Split();
                    var statement = ParseStatement(line);
                    var result = statement.Evaluate();
                    _valueTable.Update(tokens[0], result);
                    if (result > max)
                    {
                        max = result;
                    }
                    line = sr.ReadLine();
                }
            }
            return max;
        }
    }
}