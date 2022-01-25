using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class IsUnique
    {
        public static bool IsStringUniqueBruteForce(string str)
        {
            HashSet<char> letters = new HashSet<char>();
            for(int i = 0; i < str.Length; ++i)
            {
                char currChar = str[i];
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
