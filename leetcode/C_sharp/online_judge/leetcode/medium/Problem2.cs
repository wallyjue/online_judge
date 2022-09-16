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
            double digit1 = Traverse(l1);
            double digit2 = Traverse(l2);
            double result = digit1 + digit2;

            ListNode ret = null;
            while (result > 10)
            {
                ListNode node = new ListNode((int)result % 10, ret);
                
                result = result / 10;
                ret = node;
            }
            ListNode last = new ListNode((int)result % 10, ret);

            return last;
        }

        private double Traverse(ListNode node)
        {
            double ret = 0;
            int tens = 0;
            while(node != null)
            {
                ret += node.val * Math.Pow(10, tens++);
                node = node.next;
            }

            return ret;
        }
    }
}
