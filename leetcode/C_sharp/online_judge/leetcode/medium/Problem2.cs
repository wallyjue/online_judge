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
            ulong digit1 = Traverse(l1);
            ulong digit2 = Traverse(l2);
            ulong result = digit1 + digit2;

            ListNode ret = null;
            while (result >= 10)
            {
                ulong val = result % 10;
                ListNode node = new ListNode((int)val, ret);
                
                result = result / 10;
                ret = node;
            }
            ListNode last = new ListNode((int)result, ret);

            ListNode reverseTail = last, reverse = null;
            ListNode prev = null;
            while (reverseTail != null)
            {
                ListNode node = new ListNode(reverseTail.val, prev);
                prev = node;
                reverseTail = reverseTail.next;

                if (reverseTail == null)
                {
                    reverse = node;
                    break;
                }
            }


            return reverse;
        }

        private ulong Traverse(ListNode node)
        {
            ulong ret = 0;
            int tens = 0;
            while(node != null)
            {
                ret += (ulong)node.val * (ulong)Math.Pow(10, tens++);
                node = node.next;
            }

            return ret;
        }
    }
}
