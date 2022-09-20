using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ret = null, runner = null, prev = null;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                if (sum >= 10)
                {
                    carry = 1;
                    sum = sum % 10;
                }
                else carry = 0;
                runner = new ListNode(sum);
                if (prev != null)
                {
                    prev.next = runner;
                }
                
                prev = runner;
                if (ret == null)
                {
                    ret = runner;
                }
            }

            if (carry > 0)
            {
                runner = new ListNode(carry);
                if (prev != null)
                {
                    prev.next = runner;
                }
            }

            return ret;
        }
    }
}
