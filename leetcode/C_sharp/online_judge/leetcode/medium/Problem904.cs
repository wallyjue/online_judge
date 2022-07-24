using System;
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
            int fruit1 = -1, fruit2 = -1;

            for(right = 0; right < fruits.Length; right++)
            {
                if (fruit1 < 0 || fruit2 < 0)
                {
                    if (fruit1 < 0)
                    {
                        fruit1 = fruits[right];
                    }

                    if (fruit2 < 0)
                    {
                        fruit2 = fruits[right];
                    }
                }
                else if (!(fruits[right] == fruit1 || fruits[right] == fruit2))
                {
                    while (!(fruits[right] == fruit1 || fruits[right] == fruit2))
                    {
                        if (fruits[right] != fruit1)
                        {
                            fruit1 = fruits[right];
                        }
                        else if (fruits[right] != fruit2)
                        {
                            fruit2 = fruits[right];
                        }

                        left++;
                    }
                }


                ret = Math.Max(ret, right - left + 1);
            }


            return ret;
        }
    }
}
