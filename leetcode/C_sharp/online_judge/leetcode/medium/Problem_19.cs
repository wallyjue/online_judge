using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.medium
{
    class Problem_19
    {
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			ListNode node = head;
			Stack<ListNode> stack = new Stack<ListNode>();

			return node;
		}
	}

	class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}
}
