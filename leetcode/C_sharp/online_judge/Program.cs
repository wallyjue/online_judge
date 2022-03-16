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
			var easy = new online_judge.leetcode.easy.Problem70();

			var medium = new online_judge.leetcode.medium.Problem189();
			int ret = -1;

			ret = easy.ClimbStairs(1);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(2);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(3);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(4);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(5);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(6);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(7);
			Console.WriteLine("ret:" + ret);

			ret = easy.ClimbStairs(8);
			Console.WriteLine("ret:" + ret);

			Console.WriteLine("ret:" + ret);
		}
    }
}
