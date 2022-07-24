using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.medium
{
	class Problem_5
	{
		string s;
		public string LongestPalindrome2(string s)
        {
			
			this.s = s;
			string ret = string.Empty;

			for (int cnt = 0; cnt < s.Length;cnt++)
            {
				string temp = dynamicFunction(cnt, s[cnt].ToString());
				if (temp.Length > ret.Length)
                {
					ret = temp;
                }
            }

			return ret;
		}

		private string dynamicFunction(int index, string input)
        {
			string ret = input;
			int left = index, right = index;
			for(int testLength = 0; right < s.Length && left >= 0; testLength++)
            {
				if (right + 1 < s.Length && left - 1 >= 0)
                {
					var temp = this.s[left - 1].ToString() + ret + this.s[right + 1].ToString();
					if (isPalindrome(temp))
					{
						ret = temp;
					}
				}
				else if (left - 1 >= 0)
                {
					var temp = this.s[left - 1].ToString() + ret;
					if (isPalindrome(temp))
					{
						ret = temp;
					}
				}
				else if (right + 1 < s.Length)
				{
					var temp = ret + this.s[right + 1].ToString();
					if (isPalindrome(temp))
					{
						ret = temp;
					}
				}

				if (testLength % 2 == 0)
                {
					right++;
                }
				else
                {
					left--;
				}
			}

			return ret;
        }

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
