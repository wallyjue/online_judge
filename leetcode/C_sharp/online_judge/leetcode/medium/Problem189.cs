using online_judge.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    public class Problem189
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int right = nums.Length - 1, left = k - 1;

            while(left >= 0)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left--;
                right--;
            }
            
            /*
            k = k % nums.Length;
            if (nums.Length / 2 > k)
            {
                while (k > 0)
                {
                    int temp = nums[nums.Length - 1];
                    for (int cnt = nums.Length - 1; cnt > 0; cnt--)
                    {
                        nums[cnt] = nums[cnt - 1];
                    }
                    nums[0] = temp;
                    k--;
                }
            }
            else
            {
                k = nums.Length - k;
                while (k > 0)
                {
                    int temp = nums[0];
                    for (int cnt = 0; cnt < nums.Length - 1; cnt++)
                    {
                        nums[cnt] = nums[cnt + 1];
                    }
                    nums[nums.Length - 1] = temp;
                    k--;
                }
            }
            */
            // rotate to right
            /*
            while(k > 0)
            {
                int temp = nums[nums.Length - 1];
                for (int cnt = nums.Length-1; cnt > 0; cnt--)
                {
                    nums[cnt] = nums[cnt-1];
                }
                nums[0] = temp;
                k--;
            }
            */

            // rotate to left
            /*
            while (k > 0)
            {
                int temp = nums[0];
                for (int cnt = 0; cnt < nums.Length -1; cnt++)
                {
                    nums[cnt] = nums[cnt+1];
                }
                nums[nums.Length - 1] = temp;
                k--;
            }
            */
            Console.WriteLine("nums:" + Helper.IteratingString(nums));
        }
    }
}
