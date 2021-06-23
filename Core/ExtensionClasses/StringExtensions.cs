using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGNLib.Core
{
    public static class StringExtensions
    {
        /// <summary>
        /// Counts the number of a given character in a given string
        /// </summary>
        /// <param name="s1">The source string to search</param>
        /// <param name="c1">Searching our string for this character</param>
        /// <returns></returns>
        public static int CharCount(this string s1, char c1)
        {
            int count = 0;
            foreach (char c in s1)
            {
                if (c == c1) { count++; }
            }
            return count;
        }
        /// <summary>
        /// Counts the number of times a given string is found in another given string
        /// </summary>
        /// <param name="s1">The source string to search</param>
        /// <param name="s2">Searching our source string for this string</param>
        /// <returns></returns>
        public static int SubstringCount(this string s1, string s2)
        {
            //int count = 0;
            int i = 0;
            int s2length = s2.Length;

            //s1.IndexOf()
            s1.Substring(i, s2length);
            return 1;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<int> IndexesOf(this string s, char value)
        {
            bool indexing = true;
            int startIndex = 0;
            List<int> indexes = new List<int>();

            while (indexing)
            {
                int i = s.IndexOf(value, startIndex);
                if (i == -1) { indexing = false; } else { indexes.Add(i); startIndex = i + 1; }
            }
            return indexes;
        }
    }
}
