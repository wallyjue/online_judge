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

            for (int pointer = 0; pointer < arr.Length-1; pointer++)
            {
                if (arr[pointer] == 0)
                {
                    zeroCnt++;
                }
            }
            int copyTo = arr.Length - 1, copyFrom = arr.Length -1 - zeroCnt;
            for (int pointer = arr.Length - 1; pointer > 0; pointer--)
            {

            }

            return arr;
        }
    }
}
