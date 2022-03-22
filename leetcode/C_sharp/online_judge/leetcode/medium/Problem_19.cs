using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.medium
{
    internal class Problem_19
    {
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			ListNode node = head;
			Stack<ListNode> stack = new Stack<ListNode>();

			return node;
		}
	}

	internal class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}
}
