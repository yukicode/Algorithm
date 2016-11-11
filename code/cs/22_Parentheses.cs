using System;
using System.Collections.Generic;

namespace Solution
{

    //Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    public class Parenthesis
    {
        private List<string> all = new List<string>();

        public IList<string> GenerateParenthesis(int n)
        {
            GenerateParenthesis("", n, n);
            return all;
        }

        private void GenerateParenthesis(string s, int left, int right)
        {
            if (left > 0)
            {
                GenerateParenthesis(s + "(", left - 1, right);
            }
            if (left < right)
            {
                GenerateParenthesis(s + ")", left, right - 1);
            }
            if (left == 0 && right == 0)
            {
                all.Add(s);
            }
        }
    }
}
