using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem876
    {
        public ListNode MiddleNode(ListNode head)
        {
            int length = GetLength(head);
            int move = length % 2 == 0 ? (length / 2) : (length / 2) + 1;
            while (move > 0)
            {
                head = head.next;
                move--;
            }
            return head;
        }

        private int GetLength(ListNode head)
        {
            int length = 0;
            ListNode node = head;
            while (node.next != null)
            {
                node = node.next;
                length++;
            }
            return length;
        }
    }
}
