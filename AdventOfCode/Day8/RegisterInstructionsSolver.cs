using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day8
{
    public class RegisterInstructionsSolver
    {
        private ValueTable _valueTable;

        public RegisterInstructionsSolver()
        {
            _valueTable = new ValueTable();
        }

        public int Solve(string input)
        {
            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    var tokens = line.Split();
                    var statement = ParseStatement(line);
                    var result = statement.Evaluate();
                    _valueTable.Update(tokens[0],result);
                    line = sr.ReadLine();
                }
            }
            return _valueTable.Values.Max();
        }

        public Statement ParseStatement(string input)
        {
            var ret = new Statement();

            var parts = input.Split(new []{"if"}, StringSplitOptions.RemoveEmptyEntries);
            var opMatch = Regex.Match(parts[0], @"(?<left>\D+)\s(?<operator>(inc)|(dec))\s(?<right>-?\d+)");
            var compMatch = Regex.Match(parts[1], @"(?<left>\D+)\s(?<comp>(>)|(<)|(>=)|(<=)|(==)|(!=))\s(?<right>-?\d+)");
            ret.Operator = Operator.GetInstance(opMatch.Groups["operator"].Value);
            ret.Comparator = Comparator.GetInstance(compMatch.Groups["comp"].Value);
            ret.OperateLeft = _valueTable.LookUp(opMatch.Groups["left"].Value);
            ret.OperateRight = Convert.ToInt32(opMatch.Groups["right"].Value);
            ret.CompareLeft = _valueTable.LookUp(compMatch.Groups["left"].Value);
            ret.CompareRight = Convert.ToInt32(compMatch.Groups["right"].Value);

            return ret;
        }
    }
}