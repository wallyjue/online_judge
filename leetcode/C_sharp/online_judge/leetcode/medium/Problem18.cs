using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem18
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            for (int w = 0; w < nums.Length; w++)
            {
                if (w > 0 && nums[w] == nums[w - 1])
                {
                    continue;
                }

                for (int x = w + 1; x < nums.Length; x++)
                {
                    if (x > w + 1 && nums[x] == nums[x - 1])
                    {
                        continue;
                    }
                    var temp = TwoSum(nums, (long)((long)target - (long)nums[x] - (long)nums[w]), x + 1, nums[w], nums[x]);
                    result.AddRange(temp);
                }
            }
            return result;
        }

        private List<IList<int>> TwoSum(int[] nums, long target, int start, int w, int x)
        {
            List<IList<int>> result = new List<IList<int>>();
            
            int left = start, right = nums.Length - 1;
            while (left < right)
            {
                int tempSum = nums[left] + nums[right];
                if (tempSum == target)
                {
                    List<int> temp = new List<int>();
                    temp.Add(w);
                    temp.Add(x);
                    temp.Add(nums[left++]);
                    temp.Add(nums[right--]);
                    result.Add(temp);
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
                else if (tempSum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return result;
        }
    }
}
