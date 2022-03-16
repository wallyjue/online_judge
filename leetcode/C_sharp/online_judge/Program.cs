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

			var medium = new online_judge.leetcode.medium.Problem189();
			int ret = -1;


			easy.MoveZeroes(new int[] { 1, 0, 2, 0, 3 });

			easy.MoveZeroes(new int[] { 1, 0, 2, 0, 3, 0 });

			easy.MoveZeroes(new int[] { 0 });

			easy.MoveZeroes(new int[] { 0, 1, 0, 2, 0 });

			easy.MoveZeroes(new int[] { 0, 1, 0, 2, 0, 3 });

			easy.MoveZeroes(new int[] { 0, 1, 0, 2, 4 });



			Console.WriteLine("ret:" + ret);
		}
    }
}
