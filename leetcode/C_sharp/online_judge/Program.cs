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
			var easy = new online_judge.leetcode.easy.Problem_1();
			var medium = new online_judge.leetcode.medium.Problem56();
			var hard = new online_judge.leetcode.hard.Problem42();
			var explore = new online_judge.leetcode.explore.RecursionII();

			// [[1,4,5],[1,3,4],[2,6]]
			/*
			ListNode node9 = new ListNode(10, null);
			ListNode node8 = new ListNode(9, node9);

			ListNode node7 = new ListNode(6, null);
			ListNode node6 = new ListNode(2, node7);

			ListNode node5 = new ListNode(4, null);
			ListNode node4 = new ListNode(3, node5);
			ListNode node3 = new ListNode(1, node4);

			ListNode node2 = new ListNode(5, null);
			ListNode node1 = new ListNode(4, node2);
			ListNode head = new ListNode(1, node1);
			*/
			var reteasy = easy.TwoSum2(new int[] { 2, 7, 11, 15 }, 9);
			reteasy = easy.TwoSum2(new int[] { 3, 2, 4 }, 6);
			reteasy = easy.TwoSum2(new int[] { 3, 3 }, 6);
			/*
			var ret = hard.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
			Console.WriteLine("ret:" + ret);
			ret = hard.Trap(new int[] { 4, 2, 0, 3, 2, 5 });
			Console.WriteLine("ret:" + ret);
			*/

		}
    }
}
