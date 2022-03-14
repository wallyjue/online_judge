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
			var problem = new online_judge.leetcode.medium.Problem287();
			int ret = -1;
			ret = problem.FindDuplicate(new int[] { 1, 3, 4, 2, 2 });
			Console.WriteLine("ret:" + ret);
		}
    }
}
