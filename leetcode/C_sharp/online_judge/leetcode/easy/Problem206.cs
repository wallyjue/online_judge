using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem206
    {
        public ListNode ReverseList(ListNode head)
        {
            Queue<ListNode> queue = new Queue<ListNode>();
            while (head != null)
            {
                queue.Enqueue(head);
                head = head.next;
            }
            ListNode tail = null;
            while (queue.Count > 0)
            {
                ListNode temp = queue.Dequeue();
                temp.next = tail;
                tail = temp;
            }

            return tail;
        }
    }
}
