using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem139
    {
        // f(n) = f(n-1) + dictionary()
        bool[] memo;
        Hashtable table = new Hashtable();
        public bool WordBreak(string s, IList<string> wordDict)
        {
            memo = new bool[s.Length + 1];
            foreach(string word in wordDict)
            {
                table.Add(word, true);
            }

            bool ret = dynamicFunction(s, s.Length);

            return ret;
        }

        private bool dynamicFunction(string s, int length)
        {
            bool ret = false;
            if (length == 0)
            {
                return true;
            }

            if (memo[length])
            {
                return true;
            }

            memo[length] = false;
            for (int cnt = 0; cnt < length;cnt++)
            {
                bool right = table.Contains(s.Substring());
                if (!right)
                {
                    continue;
                }
            }

            /*
            foreach (string word in wordDict)
            {
                if (s.Length < word.Length)
                {
                    continue;
                }

                string substring = s.Substring(0, word.Length);
                if (substring == word)
                {
                    temp = s.Substring(word.Length, s.Length - substring.Length);
                    ret |= dynamicFunction(temp, wordDict);
                    if (ret) return ret;
                }
            }
            */
            return ret;
        }
    }
}
