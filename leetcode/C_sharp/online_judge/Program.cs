using online_judge.leetcode;
using online_judge.leetcode.easy;
using online_judge.leetcode.medium;
using System;


namespace online_judge
{
    class Program
    {
		static void Main(string[] args)
		{
			/*
				string[] lines = File.ReadAllLines(@"input.txt");
				foreach (string line in lines)
				{
					Console.WriteLine(line);
				}
			*/
			var easy = new online_judge.leetcode.easy.Problem125();
			var medium = new online_judge.leetcode.medium.Problem1721();
			var explore = new online_judge.leetcode.explore.Array101();

			ListNode node9 = new ListNode(10, null);
			ListNode node8 = new ListNode(9, node9);
			ListNode node7 = new ListNode(8, node8);
			ListNode node6 = new ListNode(7, node7);
			ListNode node5 = new ListNode(6, node6);
			
			ListNode node4 = new ListNode(5, node5);
			ListNode node3 = new ListNode(4, node4);
			ListNode node2 = new ListNode(3, node3);
			ListNode node1 = new ListNode(2, node2);
			
			ListNode head = new ListNode(1, node1);

			var ret = medium.SwapNodes(head, 6);
			Console.WriteLine("ret:" + ret);

			ListNode newnode = new ListNode(0, null);
			ret = medium.SwapNodes(newnode, 1);
			Console.WriteLine("ret:" + ret);
			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			//Console.WriteLine("ret:" + ret);
		}
    }
}
