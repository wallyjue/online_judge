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
			var easy = new online_judge.leetcode.easy.Problem283();

			var medium = new online_judge.leetcode.medium.Problem167();
			int[] ret;

			

			ret = medium.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

			ret = medium.TwoSum(new int[] { 2, 3, 4 }, 6);

			ret = medium.TwoSum(new int[] { -1, 0 }, -1);

			ret = medium.TwoSum(new int[] { 0, 3, 6 }, 6);

			Console.WriteLine("ret:" + ret);
		}
    }
}
