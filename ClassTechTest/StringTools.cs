namespace ClassTechTest
{
    using System;

    public class StringTools
    {
        #region String Tool Problems

        // <summary>
        // Find and return first duplicated char
        // </summary>
        // <param name="input"></param>
        // <returns>first duplicated char</returns>
        public string FindFirstDuplicatedCharacter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            var seenChars = new string[input.Length];
            int index = 0;
            foreach(var c in input)
            {
                var cString = c.ToString().ToUpper();
                for (int i = 0; i < index; i++)
                {
                    // Check if string is existed in seenChars array
                    if (seenChars[i] == cString)
                        return cString;
                }
                // If not, add string into array
                seenChars[index] = cString;
                index ++;
            }

            return null;
        }

        #endregion

        #region Palindrome Problems

        // <summary>
        // Check if string is palindrome
        // </summary>
        // <param name="input"></param>
        // <returns>true if string is palindrome otherwise return false </returns>
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            var array = input.ToCharArray();
            int leftIndex = 0;
            int rightIndex = array.Length - 1;

            // While left index < right index, check if left char is the same with right char
            while (leftIndex < rightIndex)
            {
                if (char.ToLower(array[leftIndex]) != char.ToLower(array[rightIndex]))
                    return false;

                leftIndex ++;
                rightIndex --;
            }

            return true;
        }
        
        // <summary>
        // Find and return largest palindrome within string
        // </summary>
        // <param name="input"></param>
        // <returns>largest palindrome</returns>
        public string FindLargestPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            if (input.Length == 1)
                return input;

            int maxLength = 0;
            var maxPalindrome = string.Empty;

            // Find all possible substring of the input string
            for (var i = 0; i < input.Length; i ++)
            {
                for (var j = i; j < input.Length; j ++)
                {
                    var subString = input.Substring(i, j- i + 1);
                    // For each substring, checking if its a palindrome
                    if (IsPalindrome(subString) && subString.Length > maxLength) 
                    {
                        maxLength = subString.Length;
                        maxPalindrome = subString;
                    }
                }
            }

            return maxLength > 1 ? maxPalindrome : null;
        }

        #endregion
    }
}
