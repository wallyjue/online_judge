using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem394
    {
        public string DecodeString(string s)
        {
            LinkedList<char> stack = new LinkedList<char>();
            StringBuilder ret = new StringBuilder();
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if (s[cnt] != ']')
                {
                    stack.AddLast(s[cnt]);
                }
                else
                {
                    StringBuilder temp = new StringBuilder();
                    while (stack.Count > 0 && stack.Last() != '[')
                    {
                        temp.Append(stack.Last());
                        stack.RemoveLast();
                    }
                    stack.RemoveLast();
                    double rep = 0;
                    double power = 0;
                    while(stack.Count >0 && stack.Last() <= '9')
                    {
                        rep += int.Parse(stack.Last().ToString()) * Math.Pow((double)10, power++);
                        stack.RemoveLast();
                    }

                    for (int cnt2 = 0; cnt2 < rep; cnt2++)
                    {
                        //for(int cnt3 = temp.Length - 1; cnt3 >= 0;cnt3--)
                        for (int cnt3 = 0; cnt3 < temp.Length; cnt3++)
                        {
                            stack.AddLast(temp[cnt3]);
                        }
                    }
                }
            }
            while(stack.Count > 0)
            {
                ret.Append(stack.First().ToString());
                stack.RemoveFirst();
            }
            
            return ret.ToString();
        }
    }
}
