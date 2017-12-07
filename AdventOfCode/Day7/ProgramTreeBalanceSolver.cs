using System.Linq;

namespace AdventOfCode.Day7
{
    public class ProgramTreeBalanceSolver : ProgramTreeSolver
    {
        public override string Solve(string input)
        {
            var root = BuildTree(input);

            while (!IsBalanced(root))
            { 
                var unbalancedChild = FindUnbalancedChild(root);
                if (unbalancedChild != null)
                {
                    root = unbalancedChild;
                }
                else // one of these children needs to chnge weight
                {
                    var distinctWeights = root.Children.Select(GetSubTreeWeight).Distinct().ToArray();
                    var amountToChange = distinctWeights.First() - distinctWeights.Last();
                    var unbalanced = GetImbalancedNode(root, distinctWeights);
                    return (unbalanced.Weight - amountToChange).ToString();
                }
            }

            return "";
        }

        public int GetSubTreeWeight(ProgramTreeNode node)
        {
            if (!node.Children.Any())
            {
                return node.Weight;
            }
            else
            {
                return node.Weight + node.Children.Sum(GetSubTreeWeight);
            }
        }

        private ProgramTreeNode GetImbalancedNode(ProgramTreeNode root, int[] distinctWeights)
        {
            if (root.Children.Count(c => GetSubTreeWeight(c) == distinctWeights.First()) == 1)
            {
                return root.Children.Single(c => GetSubTreeWeight(c) == distinctWeights.First());
            }
            else
            {
                return root.Children.Single(c => c.Weight == distinctWeights.Last());
            }
        }

        private ProgramTreeNode FindUnbalancedChild(ProgramTreeNode root)
        {
            return root.Children.SingleOrDefault(c => !IsBalanced(c));
        }

        public bool IsBalanced(ProgramTreeNode root)
        {
            return root.Children.Select(GetSubTreeWeight).Distinct().Count() == 1;
        }
    }
}