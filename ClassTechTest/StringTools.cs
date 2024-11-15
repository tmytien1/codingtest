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
        
        public string FindLargestPalindrome(string input)
        {
            return null;
        }

        #endregion
    }
}
