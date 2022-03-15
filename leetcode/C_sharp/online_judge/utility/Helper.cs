using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.utility
{
    static public class Helper
    {
        static public string IteratingString(int[] nums)
        {
            string ret = string.Empty;
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                if(cnt == 0)
                {
                    ret = $"{nums[cnt]}";
                }
                else
                {
                    ret = $"{ret}, {nums[cnt]}";
                }
            }

            return ret;
        }
    }
}
