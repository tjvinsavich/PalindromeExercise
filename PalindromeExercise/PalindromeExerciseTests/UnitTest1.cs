using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("duck", false)]
        [InlineData("sassafras", false)]
        [InlineData("madam", true)]
        public void Test1(string input, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPalindrome(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
