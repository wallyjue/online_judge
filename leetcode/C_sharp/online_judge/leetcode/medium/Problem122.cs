using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem122
    {
        public int MaxProfit2(int[] prices)
        {
            int profit = 0;
            for (int cnt = 1; cnt < prices.Length;cnt++)
            {
                if (prices[cnt] > prices[cnt - 1])
                {
                    profit = profit + prices[cnt] - prices[cnt - 1];
                }
            }

            return profit;
        }

        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;

            int profit = 0;
            int valley = 0;
            int peak = 0;

            for (int cnt = 0; cnt < prices.Length;cnt++)
            {
                if (cnt == 0)
                {
                    if (prices[cnt + 1] > prices[cnt])
                    {
                        valley = cnt;
                    }
                    else if (prices[cnt + 1] < prices[cnt])
                    {
                        peak = cnt;
                    }
                }
                else if (cnt == prices.Length - 1)
                {
                    if (prices[cnt - 1] > prices[cnt])
                    {
                        valley = cnt;
                    }
                    else if (prices[cnt - 1] < prices[cnt])
                    {
                        peak = cnt;
                        profit += prices[peak] - prices[valley];
                    }
                }
                else
                {
                    if (prices[cnt - 1] > prices[cnt] && prices[cnt + 1] >= prices[cnt])
                    {
                        valley = cnt;
                    }

                    if (prices[cnt - 1] < prices[cnt] && prices[cnt + 1] <= prices[cnt])
                    {
                        peak = cnt;
                        profit += prices[peak] - prices[valley];
                    }
                }
            }

            return profit;
        }
    }
}
