using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem28
    {
        public int StrStr(string haystack, string needle)
        {
            int ret = -1;

            if (haystack.Length == needle.Length) return haystack == needle ? 0 : -1;

            for (int cnt = 0; cnt < haystack.Length - needle.Length + 1; cnt++)
            {
                if (haystack[cnt] == needle[0])
                {
                    bool isEqual = true;
                    for(int cnt2 = 0; cnt2 < needle.Length;cnt2++)
                    {
                        if (haystack[cnt + cnt2] != needle[cnt2])
                        {
                            isEqual = false;
                            break;
                        }
                    }

                    if (isEqual) return cnt;
                }
            }

            return ret;
        }
    }
}
