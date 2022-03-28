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
			int length = GetLength(head);
			int move = length - n;

			if (move < 0) return head.next;

			while (move > 0)
			{
				node = node.next;
				move--;
			}

			ListNode nextToRemoval = node.next.next;
			node.next = nextToRemoval;
			return head;
		}

		private int GetLength(ListNode head)
		{
			int length = 0;
			ListNode node = head;
			while (node != null)
			{
				node = node.next;
				length++;
			}
			return length;
		}
	}
}
