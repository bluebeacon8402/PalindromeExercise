using System;
using Xunit;
using System.Collections.Generic;
using PalindromeExercise;



namespace Palindrome.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("madam", true)]
        [InlineData("anna", true)]
        [InlineData("mom", true )]
        [InlineData("noon", true)]
        [InlineData("hello", false)]
        public void Test1(string word, bool expected)
        {

            //arrange
            var tester = new WordSmith();

            //act
            bool actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);


        }
    }
}
