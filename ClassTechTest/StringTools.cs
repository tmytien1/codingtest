namespace ClassTechTest
{
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
            int index;
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

        public bool IsPalindrome(string input)
        {
            return true;
        }
        
        public string FindLargestPalindrome(string input)
        {
            return null;
        }

        #endregion
    }
}
