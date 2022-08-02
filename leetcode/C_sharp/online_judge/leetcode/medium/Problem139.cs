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
            /*
            Set<String> wordDictSet = new HashSet<>(wordDict);
            boolean[] dp = new boolean[s.length() + 1];
            dp[0] = true;
            for (int i = 1; i <= s.length(); i++) {
                for (int j = 0; j < i; j++) {
                    if (dp[j] && wordDictSet.contains(s.substring(j, i))) {
                        dp[i] = true;
                        break;
                    }
                }
            }
            return dp[s.length()];
            */
            memo = new bool[s.Length + 1];
            memo[0] = true;
            foreach(string word in wordDict)
            {
                table.Add(word, true);
            }

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (memo[j] && table.Contains(s.Substring(j, i - j)))
                    {
                        memo[i] = true;
                        break;
                    }
                }
            }

            return memo[s.Length];
        }
    }
}
