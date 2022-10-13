using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem299
    {
        public string GetHint(string secret, string guess)
        {
            int A = 0, B = 0;
            int[] digits = new int[10];

            for (int cnt = 0; cnt < secret.Length;cnt++)
            {
                if (secret[cnt] == guess[cnt])
                {
                    A++;
                }
                else
                {
                    digits[secret[cnt] - '0']++;
                }
                
            }

            for (int cnt = 0; cnt < secret.Length; cnt++)
            {
                if (digits[guess[cnt] - '0'] > 0 && secret[cnt] != guess[cnt])
                {
                    digits[guess[cnt] - '0']--;
                    B++;
                }
            }
            return $"{A}A{B}B";
        }
    }
}
