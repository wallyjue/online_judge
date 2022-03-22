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
			var easy = new online_judge.leetcode.easy.Problem557();
			var medium = new online_judge.leetcode.medium.Problem167();
			var explore = new online_judge.leetcode.explore.Array();
			int ret = -1;

			//ret = explore.ReplaceElements(new int[] { 2, 1});
			//Console.WriteLine("ret:" + ret);

			easy.ReverseWords("Let's take LeetCode contest");
			Console.WriteLine("ret:" + ret);

			easy.ReverseWords("God Ding");
			Console.WriteLine("ret:" + ret);

			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			Console.WriteLine("ret:" + ret);
		}
    }
}
