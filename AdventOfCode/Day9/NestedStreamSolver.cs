using System;
using System.Collections;
using System.Configuration;
using System.IO;

namespace AdventOfCode.Day9
{
    public class NestedStreamSolver
    {
        public TreeNode BuildTree(StringReader s)
        {
            var ret = new TreeNode();
            var endChar = '}';
            while ((char)s.Peek() != endChar)
            {
                var c = s.Read();
                if (c == '{')
                {
                    ret.AddChild(BuildTree(s));
                }
                else if (c == ',')
                {
                    var next = s.Read();
                    if (next == '<')
                    {
                        ret.TrashCount += ParseTrash(s);
                    }
                    else
                    {
                        ret.AddChild(BuildTree(s));
                    }
                }
                else if (c=='!')
                {
                    s.Read();
                }
                else if (c == '<')
                {
                    ret.TrashCount += ParseTrash(s);
                }
            }
            s.Read();
            return ret;
        }

        public int ParseTrash(StringReader sr)
        {
            var ret = 0;
            while ((char)sr.Peek() != '>')
            {
                char c = (char) sr.Read();
                if (c == '!')
                {
                    sr.Read();
                }
                else
                {
                    ret++;
                }
            }
            return ret;
        }

        public TreeNode BuildTree(string s)
        {
            using (var sr = new StringReader(s))
            {
                //first character will be {
                sr.Read();
                return BuildTree(sr);
            }
        }

        public virtual int Solve(string input)
        {
            var root = BuildTree(input);
            return root.GetScore(0);
        }
    }
}