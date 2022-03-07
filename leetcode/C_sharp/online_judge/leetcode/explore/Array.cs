using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.explore
{
    class Array
    {
        public int FindNumbers(int[] nums)
        {
            int ret = 0;
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                int digit = GetDigit(nums[cnt]);
                if (digit % 2 == 0)
                {
                    ret++;
                }
            }

            return ret;
        }


        public int GetDigit(int input)
        {
            int digit = 1;

            int mod = input / 10;
            while (mod > 0)
            {
                digit++;
                mod = mod / 10;

            }
            return digit;
        }

        public int[] SortedSquares(int[] nums)
        {
            int[] ret = new int[nums.Length];
            int lcnt = 0, rcnt = nums.Length-1;
            int cnt = nums.Length-1;
            for(cnt = nums.Length-1; cnt >= 0; cnt--)
            {
                int lcntAbs = nums[lcnt] >= 0 ? nums[lcnt] : -nums[lcnt];
                int rcntAbs = nums[rcnt] >= 0 ? nums[rcnt] : -nums[rcnt];
                if (lcntAbs < rcntAbs) 
                {
                    ret[cnt] = rcntAbs * rcntAbs;
                    rcnt--;
                }
                else
                {
                    ret[cnt] = lcntAbs * lcntAbs;
                    lcnt++;
                }
            }
            return ret;
        }

        public int[] DuplicateZeros(int[] arr) {
            int zeroCnt = 0;
            int length_ = arr.Length - 1;
            for (int pointer = 0; pointer <= length_ - zeroCnt; pointer++)
            {
                if (arr[pointer] == 0)
                {
        
                    if (pointer == length_ - zeroCnt)
                        {
                            // For this zero we just copy it without duplication.
                            arr[length_] = 0;
                            length_ -= 1;
                            break;
                        }
                    zeroCnt++;
                }
            }
            int last = length_ - zeroCnt;

            // Copy zero twice, and non zero once.
            for (int i = last; i >= 0; i--) {
                if (arr[i] == 0) {
                    arr[i + zeroCnt] = 0;
                    zeroCnt--;
                    arr[i + zeroCnt] = 0;
                } else {
                    arr[i + zeroCnt] = arr[i];
                }
            }

            return arr;
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                ;
            }
            else if (m == 0)
            {
                for (int cnt = 0; cnt < n ; cnt++)
                {
                    nums1[cnt] = nums2[cnt];
                }
            }
            else
            {
                int copyTo = m + n - 1;
                for (int cnt1 = m - 1, cnt2 = n - 1; copyTo >= 0; copyTo--)
                {
                    if (nums2[cnt2] >= nums1[cnt1])
                    {   
                        nums1[copyTo] = nums2[cnt2];
                        nums2[cnt2] = int.MinValue;
                        if (cnt2 > 0)cnt2--;
                    }
                    else
                    {
                        if (copyTo == cnt1) break;
                        nums1[copyTo] = nums1[cnt1];
                        nums1[cnt1] = int.MinValue;
                        if(cnt1 > 0) cnt1--;
                    }
                }
            }

            

            Console.WriteLine(nums1);
        }
    }
}
