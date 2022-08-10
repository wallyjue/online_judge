using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem12
    {
        public string IntToRoman(int num)
        {
            string ret = string.Empty;
            int dec = num % 10;
            int ten = (num % 100) / 10;
            int hundred = (num % 1000) / 100;
            int thousand = num / 1000;
            for(int cnt = 0; cnt < thousand; cnt++)
            {
                ret = ret + "M";
            }

            if (hundred > 0)
            {
                if (hundred == 4)
                {
                    ret = ret + "CD";
                }
                else if (hundred == 9)
                {
                    ret = ret + "CM";
                }
                else if (hundred == 5)
                {
                    ret = ret + "D";
                }
                else
                {
                    if (hundred > 5)
                    {
                        ret = ret + "D";
                        hundred -= 5;
                    }

                    for (int cnt = 0; cnt < hundred; cnt++)
                    {
                        ret = ret + "C";
                    }
                }
            }

            if (ten > 0)
            {
                if (ten == 4)
                {
                    ret = ret + "XL";
                }
                else if (ten == 9)
                {
                    ret = ret + "XC";
                }
                else if (ten == 5)
                {
                    ret = ret + "L";
                }
                else
                {
                    if (ten > 5)
                    {
                        ret = ret + "L";
                        ten -= 5;
                    }

                    for (int cnt = 0; cnt < ten; cnt++)
                    {
                        ret = ret + "X";
                    }
                }
            }

            if (dec > 0)
            {
                if (dec == 4)
                {
                    ret = ret + "IV";
                }
                else if (dec == 9)
                {
                    ret = ret + "IX";
                }
                else if (dec == 5)
                {
                    ret = ret + "V";
                }
                else
                {
                    if (dec > 5)
                    {
                        ret = ret + "V";
                        dec -= 5;
                    }

                    for (int cnt = 0; cnt < dec; cnt++)
                    {
                        ret = ret + "I";
                    }
                }
            }

            return ret;
        }
    }
}
