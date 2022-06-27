using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem82
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode headholder = head;
            Hashtable visited = new Hashtable();

            while (head != null)
            {
                if (visited[head.val] == null)
                {
                    visited.Add(head.val, 1);
                }
                else
                {
                    var visitedCount = (int)visited[head.val] + 1;
                    visited.Remove(head.val);
                    visited.Add(head.val, visitedCount);
                }
                head = head.next;
            }
            head = headholder;
            ListNode ret = null;
            ListNode runner = null, prev = null;
            while (head != null)
            {
                if ((int)visited[head.val] == 1)
                {
                    runner = new ListNode(head.val);
                    if (ret == null)
                    {
                        ret = runner;
                    }
                    if (prev != null)
                    {
                        prev.next = runner;
                    }
                    prev = runner;
                    runner = runner.next;
                }

                head = head.next;
            }
            return ret;
        }
    }
}
