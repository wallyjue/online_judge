using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.hackerrank
{
    internal class Rakuten1
    {
        public string solution(int A, int B, int C)
        {
            // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
            StringBuilder sb = new StringBuilder();
            int tempA = 0;
            int tempB = 0;
            int tempC = 0;
            while (A + B + C > 0)
            {
                int max = Math.Max(A, Math.Max(B, C));

                if (max == A)
                {
                    if (tempA == 2 && B == 0 && C == 0)
                    {
                        break;
                    }

                    if (tempA < 2 && A > 0)
                    {
                        A--;
                        tempA++;
                        tempB = 0;
                        tempC = 0;
                        sb.Append('a');
                    }
                    else if (tempB < 2 && B > 0)
                    {
                        B--;
                        tempB++;
                        tempA = 0;
                        tempC = 0;
                        sb.Append('b');
                    }
                    else if (tempC < 2 && C > 0)
                    {
                        C--;
                        tempC++;
                        tempA = 0;
                        tempB = 0;
                        sb.Append('c');
                    }
                }
                else if (max == B) 
                {
                    if (tempB == 2 && A == 0 && C == 0)
                    {
                        break;
                    }

                    if (tempB < 2 && B > 0)
                    {
                        B--;
                        tempB++;
                        tempA = 0;
                        tempC = 0;
                        sb.Append('b');
                    }
                    else if (tempC < 2 && C > 0)
                    {
                        C--;
                        tempC++;
                        tempA = 0;
                        tempB = 0;
                        sb.Append('c');
                    }
                    else if (tempA < 2 && A > 0)
                    {
                        A--;
                        tempA++;
                        tempB = 0;
                        tempC = 0;
                        sb.Append('a');
                    }
                }
                else
                {
                    if (tempC == 2 && A == 0 && B == 0)
                    {
                        break;
                    }

                    if (tempC < 2 && C > 0)
                    {
                        C--;
                        tempC++;
                        tempA = 0;
                        tempB = 0;
                        sb.Append('c');
                    }
                    else if (tempA < 2 && A > 0)
                    {
                        A--;
                        tempA++;
                        tempB = 0;
                        tempC = 0;
                        sb.Append('a');
                    }
                    else if (tempB < 2 && B > 0)
                    {
                        B--;
                        tempB++;
                        tempA = 0;
                        tempC = 0;
                        sb.Append('b');
                    }
                }

                
            }

            return sb.ToString();
        }
    }
}
