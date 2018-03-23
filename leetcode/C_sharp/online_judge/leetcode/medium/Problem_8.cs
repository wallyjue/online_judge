using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.medium
{
    class Problem_8
    {
		public int MyAtoi(string str)
		{
			string input = str.Trim();
			bool isNegative = false;
			char[] data = input.ToCharArray();
			isNegative = data[0] == '-' ? true : false;

			for(int cnt = 0; cnt < data.Length;cnt++)
			{
				int a = '0';
			}

			return 0;
		}
	}
}
