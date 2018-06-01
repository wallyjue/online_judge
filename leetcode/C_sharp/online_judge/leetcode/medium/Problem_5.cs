using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.medium
{
	class Problem_5
	{
		public string LongestPalindrome(string s)
		{
			string ret = null;
			int maxlength = 0;
			bool[,] isPalindromeArray = new bool[s.Length + 1, s.Length + 1];
			char[] input = s.ToCharArray();


			for (int cnt = 0; cnt < s.Length; cnt++)
			{
				isPalindromeArray[cnt, 0] = true;
				isPalindromeArray[cnt, 1] = true;
			}
			for (int windowsize = 1; windowsize <= 2; windowsize++)
			{
				for (int substringindex = 0; substringindex + windowsize <= s.Length; substringindex++)
				{

					string substring = s.Substring(substringindex, windowsize);
					bool palindrome = isPalindrome(substring);

					if (palindrome)
					{
						isPalindromeArray[substringindex, windowsize] = true;
						maxlength = windowsize;
						ret = substring;
					}
				}
			}

			for (int windowsize = 3; windowsize <= s.Length; windowsize++)
			{
				for (int substringindex = 1; substringindex - 2 + windowsize < s.Length; substringindex++)
				{
					char prev = input[substringindex - 1];
					char next = input[substringindex - 2 + windowsize];
					isPalindromeArray[substringindex - 1, windowsize] = isPalindromeArray[substringindex, windowsize - 2] &&
						prev == next;

					if (isPalindromeArray[substringindex - 1, windowsize] && windowsize > maxlength)
					{
						maxlength = windowsize;
						ret = s.Substring(substringindex - 1, windowsize);
					}
				}
			}
			return ret;
		}

		public bool isPalindrome(string input)
		{
			for (int cnt = 0; cnt < input.Length / 2; cnt++)
			{
				if (input[cnt] != input[input.Length - cnt - 1])
				{
					return false;
				}
			}
			return true;
		}

	}
}
