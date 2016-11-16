using NUnit.Framework;
using System;
using System.Collections.Generic;
using Solution;

namespace Tests
{
    class _32_Tests
    {
        [TestFixture]
        public class LongestValidParnthesesTests_AllForwardIteration
        {

            [Test]
            public void LongestValidPar_Empty()
            {
                var emptyString = "";
                var longestParFinder = new LongestValidParentheses();
                var longest = longestParFinder.LongestValidParentheses_AllForwardIteration(emptyString);

                Assert.AreEqual(longest, 0);
            }

            [Test]
            public void LongestValidPar_WholeString()
            {
                var s1 = "((())()()(()))";
                var s2 = "((((((()))))))";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_AllForwardIteration(s1);
                var longest2 = longestParFinder.LongestValidParentheses_AllForwardIteration(s2);

                Assert.AreEqual(longest1, s1.Length);
                Assert.AreEqual(longest2, s2.Length);
            }

            [Test]
            public void LongestValidPar_PartialString()
            {
                var s1 = "((())()()(())))))";
                var s2 = "((((((((()))))))";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_AllForwardIteration(s1);
                var longest2 = longestParFinder.LongestValidParentheses_AllForwardIteration(s2);

                Assert.AreEqual(longest1, s1.Length-3);
                Assert.AreEqual(longest2, s2.Length-2);
            }

            [Test]
            public void LongestValidPar_StringWithInvalidParenthesesInMiddle()
            {
                var s1 = "()(()";
                var s2 = "))))((()((";
                var s3 = "(())()(()((";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_AllForwardIteration(s1);
                var longest2 = longestParFinder.LongestValidParentheses_AllForwardIteration(s2);
                var longest3 = longestParFinder.LongestValidParentheses_AllForwardIteration(s3);
                Assert.AreEqual(longest1, 2);
                Assert.AreEqual(longest2, 2);
                Assert.AreEqual(longest3, 6);
            }

            [Test]
            public void LongestValidPar_SingleSidePerentheses()
            {
                var s1 = "((((((((((((((((((((((((((((";
                var s2 = "))))))))))))))))))))))))))))))";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_AllForwardIteration(s1);
                var longest2 = longestParFinder.LongestValidParentheses_AllForwardIteration(s2);
                Assert.AreEqual(longest1, 0);
                Assert.AreEqual(longest2, 0);
            }

            [Test]
            public void LongestValidPar_VeryLongString()
            {
                var longestParFinder = new LongestValidParentheses();
                var left = "((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((";
                var right = ")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))";
                var longString = left + right;
                var longest = longestParFinder.LongestValidParentheses_AllForwardIteration(longString);

                Assert.AreEqual(right.Length*2, longest);
            }
        }

        [TestFixture]
        public class LongestValidParnthesesTests_O_n
        {

            [Test]
            public void LongestValidPar_Empty()
            {
                var emptyString = "";
                var longestParFinder = new LongestValidParentheses();
                var longest = longestParFinder.LongestValidParentheses_O_n(emptyString);

                Assert.AreEqual(longest, 0);
            }

            [Test]
            public void LongestValidPar_WholeString()
            {
                var s1 = "((())()()(()))";
                var s2 = "((((((()))))))";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_O_n(s1);
                var longest2 = longestParFinder.LongestValidParentheses_O_n(s2);

                Assert.AreEqual(longest1, s1.Length);
                Assert.AreEqual(longest2, s2.Length);
            }

            [Test]
            public void LongestValidPar_PartialString()
            {
                var s1 = "((())()()(())))))";
                var s2 = "((((((((()))))))";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_O_n(s1);
                var longest2 = longestParFinder.LongestValidParentheses_O_n(s2);

                Assert.AreEqual(longest1, s1.Length - 3);
                Assert.AreEqual(longest2, s2.Length - 2);
            }

            [Test]
            public void LongestValidPar_StringWithInvalidPerInMiddle()
            {
                var s1 = "()(()";
                var s2 = "))))((()((";
                var s3 = "(())()(()((";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_O_n(s1);
                var longest2 = longestParFinder.LongestValidParentheses_O_n(s2);
                var longest3 = longestParFinder.LongestValidParentheses_O_n(s3);
                Assert.AreEqual(longest1, 2);
                Assert.AreEqual(longest2, 2);
                Assert.AreEqual(longest3, 6);
            }

            [Test]
            public void LongestValidPar_SingleSidePerentheses()
            {
                var s1 = "((((((((((((((((((((((((((((";
                var s2 = "))))))))))))))))))))))))))))))";
                var longestParFinder = new LongestValidParentheses();
                var longest1 = longestParFinder.LongestValidParentheses_O_n(s1);
                var longest2 = longestParFinder.LongestValidParentheses_O_n(s2);
                Assert.AreEqual(longest1, 0);
                Assert.AreEqual(longest2, 0);
            }

            [Test]
            public void LongestValidPar_VeryLongString()
            {
                var longestParFinder = new LongestValidParentheses();
                var left = "((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((";
                var right = ")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))";
                var longString = left + right;
                var longest = longestParFinder.LongestValidParentheses_O_n(longString);

                Assert.AreEqual(right.Length * 2, longest);
            }
        }
    }
}
