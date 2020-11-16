using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = "";

            for (int i = word.Length - 1; i < word.Length; i++)
            {
                reversed += word[i];
            }

            if (reversed ==  word)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}
