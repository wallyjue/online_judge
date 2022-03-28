using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem24
    {
        public ListNode SwapPairs(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            bool isOdd = false;
            while(head != null)
            {
                stack.Push(head);
                head = head.next;
                isOdd = !isOdd;
            }
            ListNode tail = null, ret = null;
            if (isOdd)
            {
                tail = stack.Pop();
                ret = tail;
            }

            while(stack.Count > 0)
            {
                ListNode first = stack.Pop();
                ListNode second = stack.Pop();

                if (first == null || second == null)
                {
                    tail = first;
                    break;
                }

                ListNode temp = first;
                first.next = second;
                second.next = tail;
                tail = first;
            }

            return tail;
        }
    }
}
