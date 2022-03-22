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
			var medium = new online_judge.leetcode.medium.Problem_19();
			var explore = new online_judge.leetcode.explore.Array();
			int ret = -1;

            //ret = explore.ReplaceElements(new int[] { 2, 1});
            //Console.WriteLine("ret:" + ret);
			
            //leetcode.medium.ListNode node9 = new leetcode.medium.ListNode(9,null);
			//leetcode.medium.ListNode node8 = new leetcode.medium.ListNode(8, node9);
			//leetcode.medium.ListNode node7 = new leetcode.medium.ListNode(7, node8);
			//leetcode.medium.ListNode node6 = new leetcode.medium.ListNode(6, node7);
			//leetcode.medium.ListNode node5 = new leetcode.medium.ListNode(5, node6);
			//leetcode.medium.ListNode node4 = new leetcode.medium.ListNode(5, null);
			//leetcode.medium.ListNode node3 = new leetcode.medium.ListNode(4, null);
			//leetcode.medium.ListNode node2 = new leetcode.medium.ListNode(3, node3);
			leetcode.medium.ListNode node1 = new leetcode.medium.ListNode(2, null);
			leetcode.medium.ListNode start = new leetcode.medium.ListNode(1, node1);
			var rett = medium.RemoveNthFromEnd(start, 1);
			Console.WriteLine("ret:" + rett);

			rett = medium.RemoveNthFromEnd(start, 2);
			Console.WriteLine("ret:" + rett);

			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			Console.WriteLine("ret:" + ret);
		}
    }
}
