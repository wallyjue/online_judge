using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem142
    {
        public ListNode DetectCycle(ListNode head)
        {
            Hashtable table = new Hashtable();
            int pos = 0;
            while (head != null)
            {
                if (table.ContainsValue(head))
                {
                    return head;
                }

                table.Add(pos++, head);
                head = head.next;
            }

            return null;
        }
    }
}
