using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int pivot = nums1.Length - 1;
            m = m - 1;
            n = n - 1;
            while(m >= 0 || n >= 0)
            {
                if (m > 0 && nums1[m] > nums2[n])
                {
                    var temp = nums1[m];
                    nums1[m] = nums1[pivot];
                    nums1[pivot] = temp;
                    m--;
                }
                else
                {
                    var temp = nums2[n];
                    nums2[n] = nums1[pivot];
                    nums1[pivot] = temp;
                    n--;
                }
                pivot--;
            }
            Console.WriteLine(nums1);
        }
    }
}
