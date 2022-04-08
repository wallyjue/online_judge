using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null) return null;

            if (lists.Length == 0) return null;
            int []ptrs = new int[lists.Length];
            ListNode head = null, runner = null;
            int proceedCnt = 0;
            
            while (!lists.All(x => x == null))
            {
                var minNode = GetMinValueNode(lists);
                if (head == null)
                {
                    head = minNode.Item1;
                    runner = minNode.Item1;
                    proceedCnt = minNode.Item2;
                    lists[proceedCnt] = lists[proceedCnt].next;
                }
                else
                {
                    runner.next = minNode.Item1;
                    proceedCnt = minNode.Item2;
                    lists[proceedCnt] = lists[proceedCnt].next;
                    runner = runner.next;
                }
            }

            return head;
        }

        private Tuple<ListNode, int> GetMinValueNode(ListNode[] lists)
        {
            int min = 10000, cnt = 0;
            ListNode ret = null;
            for(int i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null) continue;

                if (lists[i].val < min)
                {
                    ret = lists[i];
                    min = lists[i].val;
                    cnt = i;
                }
            }
            return new Tuple<ListNode, int>(ret, cnt);
        }
    }
}
