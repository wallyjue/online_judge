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
			online_judge.leetcode.explore.Array problem = new online_judge.leetcode.explore.Array();
			

			var ret = problem.DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
			Console.WriteLine(ret);
		}
    }
}
