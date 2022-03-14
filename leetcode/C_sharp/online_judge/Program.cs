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
			var problem = new online_judge.leetcode.easy.Problem704();
			int ret = -1;
			//ret = problem.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
			//Console.WriteLine("ret:" + ret);

			//ret = problem.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
			//Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -2, -1, 0, 5 }, -2);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -2,-1, 0, 5 }, 5);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -2, -1, 0, 5 }, 1);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -2, -1, 0, 5 }, -3);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -1, 0, 5 }, 5);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -1, 0, 5 }, -1);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { -1, 0, 5 }, 2);
			Console.WriteLine("ret:" + ret);

			ret = problem.Search(new int[] { 0 }, 0);
			Console.WriteLine("ret:" + ret);
		}
    }
}
