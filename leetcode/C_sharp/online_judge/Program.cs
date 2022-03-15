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
			var easy = new online_judge.leetcode.easy.Problem35();

			var medium = new online_judge.leetcode.medium.Problem189();
			int ret = -1;

			

			
			medium.Rotate(new int[] { 1, 3, 5, 6 }, 0); // 1, 3, 5, 6

			medium.Rotate(new int[] { -1, -100, 3, 99 }, 2); // 3, 99, -1, -100

			medium.Rotate(new int[] { -1, -100, 3, 99, 2, 5, 8, 6 }, 2); // 8, 6, -1, -100, 3, 99, 2, 5

			medium.Rotate(new int[] { -1, -100, 3, 99, 2, 5, 8, 6 }, 4); // 2, 5, 8, 6, -1, -100, 3, 99

			medium.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3); // 5,6,7,1,2,3,4
																 // 5, 6, 7, 4, 1, 2, 3, 

			medium.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1); // 7,1,2,3,4,5,6
																 //7, 2, 3, 4, 5, 6, 1

			medium.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 5); // 3,4,5,6,7,1,2
																 //7, 6, 1, 2, 3, 4, 5

			medium.Rotate(new int[] { 6, 7, 1, 2, 3, 4, 5 }, 5); // 1,2,3,4,5,6,7
																 // 5, 4, 6, 7, 1, 2, 3

			Console.WriteLine("ret:" + ret);
		}
    }
}
