using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem141
    {
        public bool HasCycle(ListNode head)
        {
            Hashtable table = new Hashtable();
            bool ret = false;
            int pos = 0;
            while (head != null)
            {
                if (table.ContainsValue(head))
                {
                    return true;
                }

                table.Add(pos++, head);
                head = head.next;
            }

            return ret;
        }
    }
}
