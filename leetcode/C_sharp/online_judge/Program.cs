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
			var easy = new online_judge.leetcode.easy.Problem876();
			var medium = new online_judge.leetcode.medium.Problem167();
			var explore = new online_judge.leetcode.explore.Array();
			int ret = -1;

            //ret = explore.ReplaceElements(new int[] { 2, 1});
            //Console.WriteLine("ret:" + ret);
            leetcode.easy.ListNode node9 = new leetcode.easy.ListNode(9,null);
			leetcode.easy.ListNode node8 = new leetcode.easy.ListNode(8, node9);
			leetcode.easy.ListNode node7 = new leetcode.easy.ListNode(7, node8);
			leetcode.easy.ListNode node6 = new leetcode.easy.ListNode(6, node7);
			leetcode.easy.ListNode node5 = new leetcode.easy.ListNode(5, node6);
			leetcode.easy.ListNode node4 = new leetcode.easy.ListNode(4, node5);
			leetcode.easy.ListNode node3 = new leetcode.easy.ListNode(3, node4);
			leetcode.easy.ListNode node2 = new leetcode.easy.ListNode(2, node3);
			leetcode.easy.ListNode node1 = new leetcode.easy.ListNode(1, node2);
			leetcode.easy.ListNode start = new leetcode.easy.ListNode(0, node1);
			var rett = easy.MiddleNode(start);
			Console.WriteLine("ret:" + rett);

			rett = easy.MiddleNode(node4);
			Console.WriteLine("ret:" + rett);

			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			Console.WriteLine("ret:" + ret);
		}
    }
}
