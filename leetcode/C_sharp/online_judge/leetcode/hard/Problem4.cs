using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            return Merge(nums1, nums2);
        }

        private double Merge(int[] nums1, int[] nums2)
        {
            List<int> merged = new List<int>();
            List<int> nums1list = new List<int>(nums1);
            List<int> nums2list = new List<int>(nums2);
            while (nums1list.Count > 0 && nums2list.Count > 0)
            {
                if (nums1list[0] < nums2list[0])
                {
                    merged.Add(nums1list[0]);
                    nums1list.RemoveAt(0);
                }
                else
                {
                    merged.Add(nums2list[0]);
                    nums2list.RemoveAt(0);
                }
            }

            if (nums1list.Count > 0) merged.AddRange(nums1list);
            if (nums2list.Count > 0) merged.AddRange(nums2list);

            int length = merged.Count;

            if (length % 2 == 1)
            {
                return merged[(int)Math.Floor((decimal)(length / 2))];
            }
            double a = merged[length / 2 - 1];
            double b = merged[length / 2];

            double ans = (a + b) / 2;

            return ans;
        }
    }
}
