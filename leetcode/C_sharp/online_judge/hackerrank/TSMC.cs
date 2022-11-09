using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.hackerrank
{
    internal class TSMC
    {
        public int requestsServed(List<int> timestamp, List<int> top)
        {
            timestamp.Sort();
            top.Sort();
            int req = 0;
            int timecnt = 0;
            int capacity = 5;
            Stack<int> stack = new Stack<int>();
            for (int topcnt = 0; topcnt < top.Count; topcnt++)
            {
                while (timecnt < timestamp.Count && top[topcnt] >= timestamp[timecnt])
                {
                    stack.Push(timestamp[timecnt++]);
                }

                while (stack.Count > 0 && capacity > 0)
                {
                    stack.Pop();
                    req++;
                    capacity--;
                }
                capacity = 5;
            }

            return req;
        }

        public string getString(string s)
        {
            int left = 0, right = s.Length - 1;
            StringBuilder ret = new StringBuilder(s);
            while (left < right)
            {
                if (ret[left] > ret[right])
                {
                    int leftptr = left;
                    int rightptr = right;
                    char leftchar = ret[leftptr];
                    char rightchar = ret[rightptr];
                    
                    while (leftptr < s.Length && rightptr >= 0 && leftptr < rightptr)
                    {
                        // move to next match
                        while (ret[leftptr] != leftchar)
                        {
                            leftptr++;
                        }

                        while (ret[rightptr] != rightchar)
                        {
                            rightptr--;
                        }

                        if (leftptr >= rightptr)
                        {
                            break;
                        }

                        // swap
                        if (ret[leftptr] == leftchar && ret[rightptr] == rightchar)
                        {
                            char temp = ret[leftptr];
                            ret[leftptr] = ret[rightptr];
                            ret[rightptr] = temp;
                            leftptr++;
                            rightptr--;
                        }
                    }
                    
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return ret.ToString();
        }

        private void swapchar(char c1, char c2)
        {
            char temp = c1;
            c1 = c2;
            c2 = temp;
        }

        public List<int> numBST(List<int> nodeValues)
        {
            return new List<int>();
        }
    }
}
