using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    /// <summary>
    /// Attempts at implementing Q1.1 IsUnique from Arrays and Strings
    /// </summary>
    public static class IsUnique
    {
        /// <summary>
        /// IsUnique Brute-Force implementation. Tests if a string has all unique characters
        /// 
        /// Runs in O(N) time with O(N) space-complexity where N is the length of the string
        /// </summary>
        /// <param name="str">string to test</param>
        /// <returns>Returns true if the parameter string contains all unique characters, false otherwise</returns>
        public static bool IsStringUniqueBruteForce(string str)
        {
            // Use hashset for O(1) time adds and lookups
            HashSet<char> letters = new HashSet<char>();
            for(int i = 0; i < str.Length; ++i)
            {
                char currChar = str[i];

                // If letter is contained then return false
                if(letters.Contains(currChar))
                {
                    return false;
                }
                letters.Add(currChar);
            }
            return true;
        }

        /// <summary>
        /// IsUnique implementation with no extra data-structure. Tests if a string has all unique characters.
        /// 
        /// Runs in O(N logN) time with O(1) space-complexity where N is the length of the string
        /// </summary>
        /// <param name="str">string to test</param>
        /// <returns>Returns true if the parameter string contains all unique characters, false otherwise</returns>
        public static bool IsStringUniqueNoDataStructure(string str)
        {
            // Ideally we wouldn't need this char array, and we could just sort the string.
            // In this instance we don't get the O(1) space complexity desired.
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            for(int i = 0; i < chars.Length - 1; ++i)
            {
                // Once chars are sorted any duplicate chars will be next to each other.
                // Step through the chars in chunks of two, if neighbors are duplicates, then false
                if(chars[i] == chars[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
