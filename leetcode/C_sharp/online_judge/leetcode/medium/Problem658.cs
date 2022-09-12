using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem658
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            List<int> ret = new List<int>();
            if (arr.Length == 1)
            {
                ret.Add(arr[0]);
                return ret;
            }
            if (arr.Length == k)
            {
                for (int cnt = 0; cnt < k; cnt++)
                {
                    ret.Add(arr[cnt]);
                }
                return ret;
            }

            int index = FindIndex(arr, x);
            
            int left = index, right = index + 1;
            for (int cnt = k; cnt > 0; cnt--)
            {
                if (arr[0] > x)
                {
                    ret.Add(arr[left++]);
                    continue;
                }

                if (arr[arr.Length - 1] < x)
                {
                    ret.Add(arr[left--]);
                    continue;
                }

                if (right < arr.Length && left >= 0)
                {
                    if (Math.Abs(x - arr[left]) > Math.Abs(arr[right] - x))
                    {
                        ret.Add(arr[right++]);
                    }
                    else
                    {
                        ret = ret.Prepend(arr[left--]).ToList();
                    }
                }
                else
                {
                    if (right < arr.Length)
                    {
                        ret.Add(arr[right++]);
                    }
                    if (left >= 0)
                    {
                        ret = ret.Prepend(arr[left--]).ToList();
                    }
                }
            }
            ret.Sort();
            return ret;
        }

        private int FindIndex(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            if (nums[0] > target)
            {
                return 0;
            }

            if (nums[right] < target)
            {
                return right;
            }

            if (nums.Length == 2 && nums[right] >= target && nums[0] <= target)
            {
                return 0;
            }

            while(left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left - 1 >= 0 ? left - 1 : 0;
        }
    }
}
