using System;
using System.Collections.Generic;
using System.Linq;

namespace First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "loveleetcode";
            Console.WriteLine(FirstUniqChar(s));
        }

        static int FirstUniqChar(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return -1;
            int[] hash = new int[26];
            foreach (char c in s)
                hash[c - 'a']++;
            for (int i = 0; i < s.Length; i++)
                if (hash[s[i] - 'a'] == 1) return i;

            return -1;
        }

        static int FirstUniqueChar(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return -1;
            Dictionary<char, int> kvp = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (kvp.ContainsKey(c))
                {
                    kvp[c] += 1;
                }
                else
                {
                    kvp[c] = 1;
                }
            }

            var arr = s.ToCharArray();
            return Array.IndexOf(arr, kvp.FirstOrDefault(x => x.Value == 1).Key);
        }
    }
}
