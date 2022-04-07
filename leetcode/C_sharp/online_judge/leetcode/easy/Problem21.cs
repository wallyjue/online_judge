using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            ListNode head = list1, lead = list1;
            if (list1.val <= list2.val)
            {
                head = list1;
                lead = list1;
                list1 = list1.next;
            }
            else if (list2.val <= list1.val)
            {
                head = list2;
                lead = list2;
                list2 = list2.next;
            }
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    lead.next = list2;
                    lead = lead.next;
                    list2 = list2.next;
                    continue;
                }
                if (list2 == null)
                {
                    lead.next = list1;
                    lead = lead.next;
                    list1 = list1.next;
                    continue;
                }

                if (list1.val <= list2.val)
                {
                    lead.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    lead.next = list2;
                    list2 = list2.next;
                }
                lead = lead.next;
            }

            return head;
        }
    }
}
