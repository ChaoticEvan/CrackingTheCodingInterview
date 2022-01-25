using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class IsUnique
    {
        /// <summary>
        /// IsUnique Brute-Force implementation. Tests if a string has all unique characters
        /// 
        /// Runs in O(N) time with O(N) space-complexity where N is the size of the string
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
    }
}
