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
			var easy = new online_judge.leetcode.easy.Problem1051();
			var medium = new online_judge.leetcode.medium.Problem3();
			var explore = new online_judge.leetcode.explore.Array101();
			int ret = -1;

			ret = easy.HeightChecker(new int[] { 57, 9, 24, 18, 45, 68, 
				76, 1, 45, 39, 2, 29, 2, 17, 41, 24, 5, 80, 80, 24, 37, 
				18, 8, 42, 84, 1, 70, 92, 52, 48, 71, 3, 46, 62, 2, 4, 52, 
				29, 76, 21, 27, 21, 61, 5, 12, 34, 25, 34, 35, 62, 34, 64, 
				6, 81, 85, 21, 67, 86, 40, 55, 60, 57, 77, 30, 8, 20, 53, 80, 
				84, 64, 82, 21, 77, 62, 12, 49, 74, 50, 17, 78, 31, 90, 36, 
				44, 76, 78, 73, 44, 75, 54, 53, 94, 35, 67, 19 });
			Console.WriteLine("ret:" + ret);

			ret = easy.HeightChecker(new int[] { 5, 1, 2, 3, 4 });
			Console.WriteLine("ret:" + ret);

			ret = easy.HeightChecker(new int[] { 1, 2, 3, 4, 5 });
			Console.WriteLine("ret:" + ret);

			ret = easy.HeightChecker(new int[] { 2, 2, 4, 6 });
			Console.WriteLine("ret:" + ret);

			ret = easy.HeightChecker(new int[] { 1,5,4,5,3 });
			Console.WriteLine("ret:" + ret);

			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			Console.WriteLine("ret:" + ret);
		}
    }
}
