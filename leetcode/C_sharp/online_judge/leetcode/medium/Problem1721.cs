using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem1721
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode headcopy = new ListNode(head.val,head.next);
            int length = 0;
            while (headcopy != null)
            {
                headcopy = headcopy.next;
                length++;
            }

            if (length == 1 || (length % 2 == 1 && k == length / 2 + 1))
            {
                return head;
            }

            if (k > length / 2)
            {
                k = length - k + 1;
            }
            headcopy = head;
            ListNode kth = head, swapNode;
            for (int i = 1; i < length - k + 1; i++)
            {
                if (i == k)
                {
                    kth = headcopy;
                }
                headcopy = headcopy.next;
            }

            if (k == 1)
            {
                head = kth;
            }
            swapNode = headcopy;
            int temp = swapNode.val;
            swapNode.val = kth.val;
            kth.val = temp;
            return head;
        }
    }
}
