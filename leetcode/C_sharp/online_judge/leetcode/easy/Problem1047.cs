using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem1047
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> stack = new Stack<char>();
            string ret = string.Empty;
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                char c;
                var isNotEmpty = stack.TryPeek(out c);

                if (isNotEmpty && c == s[cnt])
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(s[cnt]);
            }
            char part = ' ';
            while(stack.TryPop(out part))
            {
                ret = part + ret;
            }
            return ret;
        }
            /*
            int duplicatedIndex = DetectDuplicated(s);
            if (duplicatedIndex < 0)
            {
                return s;
            }

            string ret = string.Empty;
            for(int cnt = 0; cnt < s.Length; cnt++)
            {
                if(cnt == duplicatedIndex || cnt == duplicatedIndex+1)
                {
                    continue;
                }
                else
                {
                    ret += s[cnt];
                }
            }
            return RemoveDuplicates(ret);
        }

        private string CombineRemoval(string left, string right)
        {

        }

        private int DetectDuplicated(string s)
        {
            int ret = -1;
            for (int cnt = 0; cnt < s.Length-1; cnt++)
            {
                if (s[cnt] == s[cnt+1])
                {
                    ret = cnt;
                    break;
                }
            }
            
            return ret;
        }
            */
    }
}
