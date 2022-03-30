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
			var medium = new online_judge.leetcode.medium.Problem24();
			var explore = new online_judge.leetcode.explore.Array101();
			
			//ListNode node5 = new ListNode(6, null);
			/*
			ListNode node4 = new ListNode(5, null);
			ListNode node3 = new ListNode(4, node4);
			ListNode node2 = new ListNode(3, node3);
			ListNode node1 = new ListNode(2, node2);
			
			ListNode head = new ListNode(1, node1);
			*/
			var ret = easy.IsPalindrome("A man, a plan, a canal: Panama");
			Console.WriteLine("ret:" + ret);

			ret = easy.IsPalindrome("race a car");
			Console.WriteLine("ret:" + ret);

			ret = easy.IsPalindrome(" ");
			Console.WriteLine("ret:" + ret);

			ret = easy.IsPalindrome("a.");
			Console.WriteLine("ret:" + ret);

			ret = easy.IsPalindrome(",.");
			Console.WriteLine("ret:" + ret);


			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			//Console.WriteLine("ret:" + ret);
		}
    }
}
