using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.mockup
{
    internal class Test3
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return true;
            if (n == 1) return false;
            if (n == 2) return true;
            if (n < 0) return false;

            int power = 1;
            int powers = 0;
            for (int cnt = 1; cnt < 32; cnt++)
            {
                var ret = n & power;
                if (ret == power)
                {
                    powers++;
                    if (powers >= 2) return false;
                }

                power *= 2;
            }

            return true;
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            Hashtable table = new Hashtable();
            List<int> ret = new List<int>();
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                if (!table.Contains(nums[cnt]))
                {
                    table.Add(nums[cnt], true);
                }
            }

            for (int cnt = 1; cnt <= nums.Length; cnt++)
            {
                if (!table.Contains(cnt))
                {
                    ret.Add(cnt);
                }
            }

            return ret;
        }
    }
}
