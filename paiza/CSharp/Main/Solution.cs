using System;

namespace Solution
{
	class Solution
	{
		static void Main(string[] args)
		{
			int a = Int32.Parse(Console.ReadLine().Trim());
			for(int cnt = 0; cnt < a; cnt++){
				Console.Write("*");
			}
			Console.WriteLine("");
		}
	}
}
