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


			//problem.Merge(new int[] { 1, 2, 3, 5, 0, 0, 0 }, 4, new int[] { 2, 5, 6 }, 3);

			//problem.Merge(new int[] { 1 }, 1, new int[] { }, 0);

			//problem.Merge(new int[] { 7,8,10,11,0,0,0,0,0 }, 4, new int[] {1,3,4,5,6 }, 5);

			var ret = problem.RemoveDuplicates(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 });

			ret = problem.RemoveDuplicates(new int[] {});
			Console.WriteLine("ret:" + ret);
		}
    }
}
