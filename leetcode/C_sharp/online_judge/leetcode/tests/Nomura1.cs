using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.tests
{
    internal class Nomura1
    {
        public void solution(int N) {
            int enable_print = N % 10;
            while (N > 0) {
                enable_print = N % 10 + N / 10;
                if (enable_print == 0 && N % 10 != 0) {
                    enable_print = 1;
                }
                if (enable_print >= 0) {
                    Console.Write(N % 10);
                }
                N = N / 10;
            }
        }
    }
}
