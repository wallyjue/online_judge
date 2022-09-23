using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode ret = null;
            Hashtable table = new Hashtable();
            while(headA != null)
            {
                table.Add(headA, headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (table.Contains(headB))
                {
                    return headB;
                }

                headB = headB.next;
            }

            return ret;
        }
    }
}
