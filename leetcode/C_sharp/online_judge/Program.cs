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
			var easy = new online_judge.leetcode.easy.Problem448();
			var medium = new online_judge.leetcode.medium.Problem567();
			var explore = new online_judge.leetcode.explore.Array101();
			bool ret = false;

			//ret = medium.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0 });
			//Console.WriteLine("ret:" + ret);

			ret = medium.CheckInclusion("ab", "eidbaooo");
			Console.WriteLine("ret:" + ret);

			ret = medium.CheckInclusion("ab", "eidboaoo");
			Console.WriteLine("ret:" + ret);

			ret = medium.CheckInclusion("adc", "dcda");
			Console.WriteLine("ret:" + ret);

			ret = medium.CheckInclusion("ccc", "cbac");
			Console.WriteLine("ret:" + ret);

			ret = medium.CheckInclusion("abc", "dbbabcbaba");
			Console.WriteLine("ret:" + ret);

			//ret = explore.ReplaceElements(new int[] { 3, 2,1,9,5,2,7,1,3, 4});
			//Console.WriteLine("ret:" + ret);
		}
    }
}
