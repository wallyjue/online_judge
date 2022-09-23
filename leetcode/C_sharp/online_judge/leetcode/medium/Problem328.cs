using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem328
    {
        public ListNode OddEvenList(ListNode head)
        {
            bool isOdd = true;

            ListNode ret = null;
            ListNode odd = null, even = null;
            ListNode evenhead = null;
            ListNode runner = head;
            while (runner != null)
            {
                if (ret == null)
                {
                    ret = runner;
                }

                if (!isOdd)
                {
                    if (evenhead == null)
                    {
                        evenhead = runner;
                    }
                    if (even != null)
                    {
                        even.next = runner;
                    }

                    even = runner;
                }
                else
                {
                    if (odd != null)
                    {
                        odd.next = runner;
                    }

                    odd = runner;
                }

                isOdd = !isOdd;
                runner = runner.next;
            }

            if (even != null)
            {
                even.next = null;
            }

            if (evenhead != null)
            {
                odd.next = evenhead;
            }

            return ret;
        }
    }
}
