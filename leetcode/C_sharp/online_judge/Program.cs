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
			var problem = new online_judge.leetcode.easy.Problem35();
			int ret = -1;

			ret = problem.SearchInsert(new int[] { 1, 3}, 3); // 1
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { 1, 3}, 1); // 0
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { 3 }, 3); // 0
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { 1 }, 3); // 1
			Console.WriteLine("ret:" + ret);


			ret = problem.SearchInsert(new int[] { -1, 0, 2, 3, 4, 7, 9 }, 8); // 6
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { -1, 0, 2, 3, 4, 7, 9 }, 10); // 7
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { -1, 0, 2, 3, 4, 7, 9 }, 1); // 2
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { -1, 0, 2, 3, 4, 7, 9 }, -3); // 0
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { -1, 0, 2, 3, 4, 7, 9 }, 3); // 3
			Console.WriteLine("ret:" + ret);


			ret = problem.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
			Console.WriteLine("ret:" + ret);

			ret = problem.SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
			Console.WriteLine("ret:" + ret);
		}
    }
}
