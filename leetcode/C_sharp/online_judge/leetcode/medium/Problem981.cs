using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class TimeMap
    {
        List<Hashtable> tables;
        Hashtable indices;
        Hashtable timestampTable;
        public TimeMap()
        {
            tables = new List<Hashtable>();
            indices = new Hashtable();
            timestampTable = new Hashtable();
        }

        public void Set(string key, string value, int timestamp)
        {
            //indices.Add(timestamp);
            if (indices.ContainsKey(key))
            {
                List<int> indexes = (List<int>)indices[key];
                indexes.Add(timestamp);
            }
            else
            {
                indices.Add(key, new List<int>() { timestamp });
            }


            Hashtable table;
            
            table = new Hashtable();
            table.Add(key, value);
            tables.Add(table);

            timestampTable.Add(timestamp, tables.Count - 1);
            
        }

        public string Get(string key, int timestamp)
        {
            int timeStampIndex = GetMinIndex2((List<int>)indices[key], timestamp);
            if (timeStampIndex < 0)
            {
                return string.Empty;
            }
            int index = (int)timestampTable[timeStampIndex];
            Hashtable table = tables[index];
            return (string)table[key] ?? string.Empty;
        }

        public int GetMinIndex2(List<int> nums, int target)
        {
            if (nums == null)
            {
                return -1;
            }

            nums.Reverse();
            foreach(int num in nums)
            {
                if (num <= target)
                {
                    nums.Reverse();
                    return num;
                }
            }
            nums.Reverse();
            return -1;
        }

        public int GetMinIndex(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (nums[left] <= target)
            {
                return left;
            }
            else
            {
                return left - 1;
            }
        }
    }
}
