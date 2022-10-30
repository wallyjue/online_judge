using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.tests
{
    internal class Nomura2
    {
        public int solution(int N)
        {
            if (N == 0) return 50;
            bool isNagative = N < 0;
            int ret = 0;
            LinkedList<int> list = new LinkedList<int>();
            int ori = N;
            N = isNagative ? -1 * N : N;
            int maxDigit = 0, power = 0;
            while (N > 0)
            {
                if (isNagative)
                {
                    if (N == 0 || N % 10 > 5)
                    {
                        maxDigit = power;
                    }
                }
                else
                {
                    if (N % 10 <= 5)
                    {
                        maxDigit = power;
                    }
                }
                power++;
                N /= 10;
            }
            N = isNagative ? -1 * ori : ori;
            power = 0;
            while (N > 0)
            {
                list.AddLast(N % 10);
                if (power == maxDigit)
                {
                    list.AddLast(5);
                }

                power++;
                N /= 10;
            }

            power = 0;
            while (list.Count > 0)
            {
                ret += list.Take(1).First() * (int)Math.Pow(10, power++);
                list.RemoveFirst();
            }

            if (isNagative) ret = -1 * ret;
            return ret;
            /*
            int ori = N;
            N = isNagative ? -1 * N : N;
            int maxDigit = 0, power = 1;
            int ret = 0;
            while (N > 0)
            {
                int num = N % 10;
                if (isNagative)
                {
                    if (num > 5 || num == 0)
                    {
                        maxDigit = power;
                    }
                }
                else
                {
                    if (num <= 5)
                    {
                        maxDigit = power;
                    }
                }
                power++;
                N /= 10;
            }
            N = ori;
            power = 0;
            while (!isNagative && N > 0 || isNagative && N < 0)
            {
                int num = N % 10;
                ret = ret + num * (int)Math.Pow(10, power++);
                if (maxDigit == power)
                {
                    if (isNagative)
                    {
                        ret = ret - 5 * (int)Math.Pow(10, power);
                    }
                    else
                    {
                        ret = ret + 5 * (int)Math.Pow(10, power++);
                    }
                }
                N /= 10;
            }
            */
        }
    }
}
