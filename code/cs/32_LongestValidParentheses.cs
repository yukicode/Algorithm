using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    /*Given a string containing just the characters '(' and ')', 
    *find the length of the longest valid (well-formed) parentheses substring.
    *For "(()", the longest valid parentheses substring is "()", which has length = 2.
    */
    public class LongestValidParentheses
    {
        public int LongestValidParentheses_O_n2(string s)
        {
            var length = s.Length;
            var maxCount = 0;
            for (var i = 0; i < length; i++)
            {
                var count = 0;
                for (var j = i; j < length; j++)
                {
                    if (s[j] == '(') { count++; }
                    if (s[j] == ')') { count--; }
                    if (count == 0)
                    {
                        maxCount = j - i + 1 > maxCount ? j - i + 1 : maxCount;
                    }
                    if (count < 0)
                    {
                        break;
                    }
                }
            }
            return maxCount;
        }

        public int LongestValidParentheses_O_n(string s)
        {
            int left = 0;
            int right = s.Length;
            while (left<s.Length)
            {
                if (s[left] == ')')
                    left++;
                else break;
            }
            while (right > 0)
            {
                if (s[right-1] == '(')
                    right--;
                else break;
            }
            var valueMap = new int[right - left];
            var reverseMap = new int[right - left];
            for (var i=left; i< right; i++)
            {
                valueMap[i - left] = s[i] == '(' ? 1 : -1;
                reverseMap[i - left] = s[right - i + left - 1] == '(' ? -1 : 1;
            }

            var beginIndex = 0;
            var endIndex = 0;
            var value = 0;
            var maxCount = 0;

            while(endIndex < valueMap.Length)
            {
                value += valueMap[endIndex++];
                while (value < 0)
                {
                    value -= valueMap[beginIndex++];
                }
                if (value == 0)
                {
                    UpdateMaxCount(ref maxCount, beginIndex, endIndex);
                }
            }

            var reverseBeginIndex = 0;
            var reverseEndIndex = 0;
            value = 0;
            while (reverseEndIndex < reverseMap.Length)
            {
                value += reverseMap[reverseEndIndex++];
                while (value < 0)
                {
                    value -= reverseMap[reverseBeginIndex++];
                }
                if (value == 0)
                {
                    UpdateMaxCount(ref maxCount, reverseBeginIndex, reverseEndIndex);
                }
            }
            return maxCount;
        }

        private void UpdateMaxCount(ref int maxCount, int beginIndex, int endIndex)
        {
            var currentCount = endIndex - beginIndex;
            maxCount = currentCount > maxCount ? currentCount : maxCount;
        }
    }
}
