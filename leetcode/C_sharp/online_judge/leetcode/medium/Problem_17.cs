using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.medium
{
	class Problem_17
	{
		public IList<string> LetterCombinations(string digits)
		{
			if (digits == "") return new List<string>();

			char[] input = digits.ToCharArray();

			Dictionary<char, char[]> maps = new Dictionary<char, char[]>();
			maps.Add('2', "abc".ToCharArray());
			maps.Add('3', "def".ToCharArray());
			maps.Add('4', "ghi".ToCharArray());
			maps.Add('5', "jkl".ToCharArray());
			maps.Add('6', "mno".ToCharArray());
			maps.Add('7', "pqrs".ToCharArray());
			maps.Add('8', "tuv".ToCharArray());
			maps.Add('9', "wxyz".ToCharArray());

			Dictionary<int, List<string>> returns = new Dictionary<int, List<string>>();
			List<string> temp;
			for (int inputcnt = 0; inputcnt < input.Length; inputcnt++){

				var origin = returns.GetValueOrDefault(inputcnt-1);
				if (origin == null){
					temp = new List<string>();
					char[] alphabets = maps.GetValueOrDefault(input[inputcnt]);
					for (int cnt = 0; cnt < alphabets.Length; cnt++)
					{
						temp.Add(alphabets[cnt].ToString());
					}

				}else{
					temp = new List<string>();
					origin.ForEach((x) => {
						
						char[] alphabets = maps.GetValueOrDefault(input[inputcnt]);

						for (int cnt = 0; cnt < alphabets.Length; cnt++)
						{
							temp.Add($"{x}{alphabets[cnt].ToString()}");
						}
					});
				}
				returns.Add(inputcnt, temp);
			}
			return returns.GetValueOrDefault(digits.Length-1);
		}
	}
}
