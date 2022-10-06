using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem740
    {
        // dynamic function
        // dp(n) = Math.Max( dp(n - 2) + maps[n], dp(n-1))
        public int DeleteAndEarn(int[] nums)
        {
            Array.Sort(nums);
            int[] dp = new int[nums.Length + 1];
            Dictionary<int, int> maps = new Dictionary<int, int>();
            for (int cnt = 0;cnt < nums.Length;cnt++)
            {
                if (maps.ContainsKey(nums[cnt]))
                {
                    int value = maps[nums[cnt]];
                    maps.Remove(nums[cnt]);
                    maps.Add(nums[cnt], value + nums[cnt]);
                }
                else
                {
                    maps.Add(nums[cnt], nums[cnt]);
                }
            }
            Hashtable picked = new Hashtable();
            int mapIndex = 1;
            dp[0] = 0;
            KeyValuePair<int, int> prev = new KeyValuePair<int, int>();
            int max = int.MinValue;
            foreach (var item in maps)
            {
                if (mapIndex == 1)
                {
                    dp[mapIndex] = item.Value;
                    picked.Add(item.Key, true);
                }
                else
                {
                    if (item.Key - 1 > prev.Key)
                    {
                        dp[mapIndex] = item.Value + max;
                        picked.Add(item.Key, true);
                    }
                    else if (dp[mapIndex - 1] < item.Value + dp[mapIndex - 2])
                    {
                        dp[mapIndex] = item.Value + dp[mapIndex - 2];
                        picked.Add(item.Key, true);
                    }
                    else
                    {
                        dp[mapIndex] = dp[mapIndex - 1];
                    }
                }
                prev = item;
                max = Math.Max(max, dp[mapIndex]);
                mapIndex++;
            }

            return dp[maps.Count];
        }
    }
}
