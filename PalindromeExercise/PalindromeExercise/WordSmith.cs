using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string input)
        {
            var endIndex = input.Length - 1;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != (input[endIndex - i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
