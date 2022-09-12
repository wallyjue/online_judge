using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem143
    {
        public void ReorderList(ListNode head)
        {
            ListNode reverseTail = head, reverse = null;
            ListNode prev = null;
            int nodeCnt = 0;
            while(reverseTail != null)
            {
                ListNode node = new ListNode(reverseTail.val, prev);
                nodeCnt++;
                prev = node;
                reverseTail = reverseTail.next;

                if (reverseTail == null)
                {
                    reverse = node;
                    break;
                }
            }
            bool newHead = true, isForward = true;
            ListNode forward = head;
            while (nodeCnt > 0)
            {
                ListNode node = new ListNode();
                if (newHead)
                {
                    head = node;
                    newHead = false;
                }
                else
                {
                    prev.next = node;
                }
                nodeCnt--;

                if (isForward)
                {
                    node.val = forward.val;
                    forward = forward.next;
                }
                else
                {
                    node.val = reverse.val;
                    reverse = reverse.next;
                }
                prev = node;
                isForward = !isForward;
            }

            System.Console.WriteLine("Stop");
        }
    }
}
