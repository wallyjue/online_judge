using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using online_judge.utility;

namespace online_judge.leetcode.explore
{
    class Array101
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

        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int ret = 0;
            int leftPointer = -1, rightPointer = nums.Length - 1;
            for (int cnt = 0; cnt < nums.Length ; cnt++)
            {
                if (nums[cnt] == val) 
                {
                    if (leftPointer < 0) leftPointer = cnt;
                }
                else
                {
                    ret++;
                    rightPointer = cnt;
                }
            }

            if (leftPointer < 0)
            {
                return nums.Length;
            }

            while (rightPointer >= leftPointer)
            {
                if (nums[leftPointer] == val && nums[rightPointer] != val)
                {
                    int temp = nums[leftPointer];
                    nums[leftPointer] = nums[rightPointer];
                    nums[rightPointer] = temp;
                }

                if (nums[leftPointer] != val) leftPointer++;
                if (nums[rightPointer] == val) rightPointer--;
            }

            return ret;
        }

        public int RemoveDuplicates(int[] nums)
        {
            int ret = 0;
            int currentValue = -101, copyTo = 0;

            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (nums[cnt] > currentValue)
                {
                    currentValue = nums[cnt];
                    nums[copyTo] = nums[cnt];
                    ret++;
                    copyTo++;
                }
            }

            return ret;
        }

        public bool CheckIfExist(int[] arr)
        {
            Hashtable hashtable = new Hashtable();
            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (hashtable.ContainsKey(arr[cnt] * 2) || (hashtable.ContainsKey(arr[cnt] / 2) && arr[cnt] % 2 == 0))
                {
                    return true;
                }

                if (!hashtable.ContainsKey(arr[cnt])) hashtable.Add(arr[cnt], true);
            }

            return false;
        }

        public bool ValidMountainArray(int[] arr)
        {
            int cnt = 0, max = arr[0], maxIndex = 0;

            while(cnt< arr.Length)
            {
                if(max < arr[cnt])
                {
                    max = arr[cnt];
                    maxIndex = cnt;
                }
                cnt++;
            }

            if (maxIndex == 0 || maxIndex == arr.Length-1) return false;

            for(cnt = 0; cnt < maxIndex; cnt++)
            {
                if (arr[cnt + 1] <= arr[cnt]) return false;
            }

            for (cnt = arr.Length -1; cnt > maxIndex; cnt--)
            {
                if (arr[cnt - 1] <= arr[cnt]) return false;
            }

            return true;
        }

        public int[] ReplaceElements(int[] arr)
        {
            int[] nextmax = new int[] { -1, -1 };
            for (int cnt = 0; cnt < arr.Length;cnt++)
            {
                if (nextmax[1] > arr[cnt])
                {
                    arr[cnt] = nextmax[0];
                }
                else
                {
                    nextmax = FindNextMax(arr, cnt+1);
                    arr[cnt] = nextmax[0];
                }
            }
            arr[arr.Length-1] = -1;

            Console.WriteLine(Helper.IteratingString(arr));
            return arr;
        }

        private int[] FindNextMax(int[] arr, int start = 0)
        {
            int max = 0, index = start, maxIndex = 0;
            while(index < arr.Length)
            {
                if(arr[index] >= max)
                {
                    max = arr[index];
                    maxIndex = index;
                }
                index++;
            }

            return new int[] { max, maxIndex };
        }
    }
}
