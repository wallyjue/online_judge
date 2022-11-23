using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.mockup
{
    internal class Test4
    {
        public IList<int> PancakeSort(int[] arr)
        {
            List<int> ret = new List<int>();
            int left = 0, right = arr.Length - 1;

            for (int flipcnt = arr.Length; flipcnt >= 2; flipcnt--)
            {
                int index = Find(arr, flipcnt);
                left = 0;
                right = index;
                while(left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;

                    left++;
                    right--;
                }

                ret.Add(index + 1);
                left = 0;
                right = flipcnt - 1;
                while (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;

                    left++;
                    right--;
                }

                ret.Add(flipcnt);
            }

            return ret;
        }

        private int Find(int[] arr, int target) 
        { 
            for(int cnt = 0; cnt < arr.Length;cnt++)
            {
                if (arr[cnt] == target) return cnt;
            }
            return -1;
        }

        public int FindUnsortedSubarray(int[] nums)
        {
            int[] sorted = new int[nums.Length];

            Array.Copy(nums, sorted, nums.Length);
            Array.Sort(sorted);
            int left = 0, right = nums.Length - 1;
            bool isChanged = false;
            for(int cnt = 0; cnt < nums.Length;cnt++)
            {
                if (nums[cnt] != sorted[cnt])
                {
                    left = cnt;
                    isChanged = true;

                    break;
                }
            }
            for (int cnt = nums.Length - 1; cnt > 0; cnt--)
            {
                if (nums[cnt] != sorted[cnt])
                {
                    right = cnt;
                    isChanged = true;
                    break;
                }
            }

            if (!isChanged) return 0;

            return right - left + 1;
        }

        private int FindTwisted(int[] nums, bool positive)
        {
            int index = 0;
            if (positive) 
            {
                for (int cnt = 1; cnt < nums.Length;cnt++)
                {
                    if (nums[cnt - 1] > nums[cnt]) return cnt - 1;
                }
            }
            else
            {
                for (int cnt = nums.Length - 1; cnt > 0;cnt--)
                {
                    if (nums[cnt] < nums[cnt - 1]) return cnt;
                }
            }

            return index;
        }

    }
}
