using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem2446
    {
        public bool HaveConflict(string[] event1, string[] event2)
        {
            bool ret = false;
            int event1Start = 0;
            int event1End = 0;

            int event2Start = 0;
            int event2End = 0;

            event1Start = (event1[0][0] - '0') * 600;
            event1Start += (event1[0][1] - '0') * 60;
            event1Start += (event1[0][3] - '0') * 10;
            event1Start += (event1[0][4] - '0');

            event1End = (event1[1][0] - '0') * 600;
            event1End += (event1[1][1] - '0') * 60;
            event1End += (event1[1][3] - '0') * 10;
            event1End += (event1[1][4] - '0');

            event2Start = (event2[0][0] - '0') * 600;
            event2Start += (event2[0][1] - '0') * 60;
            event2Start += (event2[0][3] - '0') * 10;
            event2Start += (event2[0][4] - '0');

            event2End = (event2[1][0] - '0') * 600;
            event2End += (event2[1][1] - '0') * 60;
            event2End += (event2[1][3] - '0') * 10;
            event2End += (event2[1][4] - '0');

            if (event1Start < event2Start)
            {
                ret = event1End >= event2Start;
            }
            else if (event1Start > event2Start)
            {
                ret = event2End >= event1Start;
            }
            else
            {
                ret = true;
            }
            return ret;
        }
    }
}
