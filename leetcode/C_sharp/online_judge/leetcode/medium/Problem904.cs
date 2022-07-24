using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem904
    {
        public int TotalFruit(int[] fruits)
        {
            int ret = 0;
            int left = 0, right = 0;
            int newFruit = -1, lastFruit = -1;

            for (right = 0; right < fruits.Length; right++)
            {
                if (newFruit < 0 || lastFruit < 0)
                {
                    if (newFruit < 0)
                    {
                        newFruit = fruits[right];
                    }
                    else if (lastFruit < 0 && newFruit != fruits[right])
                    {
                        lastFruit = newFruit;
                        newFruit = fruits[right];
                    }
                }
                else if (!(fruits[right] == newFruit || fruits[right] == lastFruit))
                {
                    left = right;
                    lastFruit = newFruit;
                    newFruit = fruits[right];
                    while (left >= 0)
                    {
                        left--;
                        if (!(fruits[left] == newFruit || fruits[left] == lastFruit))
                        {
                            left++;
                            break;
                        }
                    }
                }
                else
                {
                    if (fruits[right] != newFruit) 
                    {
                        int temp = newFruit;
                        newFruit = lastFruit;
                        lastFruit = temp;
                    }
                }
                
                ret = Math.Max(ret, right - left + 1);
            }
            return ret;
        }
    }
}
