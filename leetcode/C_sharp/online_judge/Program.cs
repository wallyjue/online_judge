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
			var easy = new online_judge.leetcode.easy.Problem1047();
			var medium = new online_judge.leetcode.medium.Problem96();
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

			var ret = easy.RemoveDuplicates("abbaca");
			Console.WriteLine("ret:" + ret);

			ret = easy.RemoveDuplicates("azxxzy");
			Console.WriteLine("ret:" + ret);

			ret = easy.RemoveDuplicates("aabbcc");
			Console.WriteLine("ret:" + ret);

			ret = easy.RemoveDuplicates("");
			Console.WriteLine("ret:" + ret);

			ret = easy.RemoveDuplicates("aaa");
			Console.WriteLine("ret:" + ret);
			//var ret = hard.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
			//Console.WriteLine("ret:" + ret);
			//var ret = hard.Trap(new int[] { 4, 2, 0, 3, 2, 5 });
			//Console.WriteLine("ret:" + ret);

			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			//Console.WriteLine("ret:" + ret);
		}
    }
}
