using online_judge.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int index1 = 0, index2 = numbers.Length - 1;
            while (index1 < index2)
            {
                int sum = numbers[index1] + numbers[index2];

                if (sum == target)
                {
                    index1++;
                    index2++;
                    break;
                }
                else if (sum < target)
                {
                    ++index1;
                }
                else
                {
                    --index2;
                }

            }
            Console.WriteLine(Helper.IteratingString(new int[] { index1, index2 }));
            return new int[] { index1, index2 };
        }
    }
}
