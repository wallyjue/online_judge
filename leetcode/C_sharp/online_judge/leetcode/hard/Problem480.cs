using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem480
    {
        Dictionary<int, int> firsthalf;
        Dictionary<int, int> secondhalf;
        int firstMax = int.MinValue, secondMin = int.MaxValue;
        int firstCnt = 0, secondCnt = 0;
        bool hasValue = false;
        int value1 = 0, value2 = 0;
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            double[] ret = new double[nums.Length - k + 1];
            firsthalf = new Dictionary<int, int>();
            secondhalf = new Dictionary<int, int>();
            firstMax = int.MinValue;
            secondMin = int.MaxValue;
            hasValue = false;
            firstCnt = 0; 
            secondCnt = 0;
            value1 = 0; 
            value2 = 0;
            for (int cnt = 0; cnt < k;cnt++)
            {
                if (cnt == 0)
                {
                    firsthalf.Add(nums[cnt], 1);
                    firstMax = Math.Max(firstMax, nums[cnt]);
                    firstCnt++;
                }
                else
                {
                    hasValue = firsthalf.TryGetValue(nums[cnt], out value1);
                    if (hasValue)
                    {
                        firsthalf.Remove(nums[cnt]);
                        firsthalf.Add(nums[cnt], value1 + 1);
                    }
                    else
                    {
                        firsthalf.Add(nums[cnt], 1);
                    }

                    firstMax = Math.Max(firstMax, nums[cnt]);
                    firstCnt++;
                }

                // if nums[cnt] < firstMax
                // then add to firsthalf, update firstMax
                // else 
                // then add to secondhalf, update secondMin

                // balance:
                // if k is even
                // while (secondhalf.count != firsthalf.count)
                // {
                //   if secondhalf.count > firsthalf.count
                //   then
                //      secondhalf.getvalue(nums[cnt])
                //      firsthalf.add the value above
                // }
            }
            Balance(k);
            double median = 0;

            median = k % 2 == 0 ? (double)((long)firstMax + (long)secondMin)/2: firstMax;
            ret[0] = median;

            for (int cnt = 0; cnt < nums.Length - k; cnt++)
            {
                if (nums[cnt + k] > secondMin)
                {
                    hasValue = secondhalf.TryGetValue(nums[cnt + k], out value1);
                    if (hasValue)
                    {
                        secondhalf.Remove(nums[cnt + k]);
                        secondhalf.Add(nums[cnt + k], value1 + 1);
                    }
                    else
                    {
                        secondhalf.Add(nums[cnt + k], 1);
                    }
                    secondMin = Math.Min(secondMin, nums[cnt + k]);
                    secondCnt++;
                }
                else
                {
                    hasValue = firsthalf.TryGetValue(nums[cnt + k], out value1);
                    if (hasValue)
                    {
                        firsthalf.Remove(nums[cnt + k]);
                        firsthalf.Add(nums[cnt + k], value1 + 1);
                    }
                    else
                    {
                        firsthalf.Add(nums[cnt + k], 1);
                    }
                    firstMax = Math.Max(firstMax, nums[cnt + k]);
                    firstCnt++;
                }

                

                hasValue = firsthalf.TryGetValue(nums[cnt], out value1);
                if (hasValue)
                {
                    firstCnt--;
                    if (value1 > 1)
                    {
                        firsthalf.Remove(nums[cnt]);
                        firsthalf.Add(nums[cnt], value1 - 1);
                    }
                    else
                    {
                        firsthalf.Remove(nums[cnt]);
                        if (firsthalf.Count > 0)
                        {
                            firstMax = firsthalf.MaxBy(k => k.Key).Key;
                        }
                        else
                        {
                            firstMax = int.MinValue;
                        }
                    }
                }
                else
                {
                    hasValue = secondhalf.TryGetValue(nums[cnt], out value2);
                    secondCnt--;
                    if (value2 > 1)
                    {
                        secondhalf.Remove(nums[cnt]);
                        secondhalf.Add(nums[cnt], value2 - 1);
                    }
                    else
                    {
                        secondhalf.Remove(nums[cnt]);
                        
                        if (secondhalf.Count > 0)
                        {
                            secondMin = secondhalf.MinBy(k => k.Key).Key;
                        }
                        else
                        {
                            secondMin = int.MaxValue;
                        }
                    }
                }

                Balance(k);
                median = k % 2 == 0 ? (double)((long)firstMax + (long)secondMin) / 2 : firstMax;
                ret[cnt+1] = median;
            }

            return ret;
        }

        private void Balance(int k)
        {
            if (k % 2 == 0)
            {
                while (secondCnt != firstCnt)
                {
                    if (secondCnt > firstCnt)
                    {
                        hasValue = secondhalf.TryGetValue(secondMin, out value1);
                        secondhalf.Remove(secondMin);
                        if (value1 > 1)
                        {
                            secondhalf.Add(secondMin, value1 - 1);
                        }

                        hasValue = firsthalf.TryGetValue(secondMin, out value2);
                        if (hasValue)
                        {
                            firsthalf.Remove(secondMin);
                            firsthalf.Add(secondMin, value2 + 1);
                        }
                        else
                        {
                            firsthalf.Add(secondMin, 1);
                        }
                        firstMax = Math.Max(secondMin, firstMax);
                        if (value1 == 1)
                        {
                            secondMin = secondhalf.MinBy(k => k.Key).Key;
                        }


                        secondCnt--;
                        firstCnt++;
                    }
                    else
                    {
                        hasValue = firsthalf.TryGetValue(firstMax, out value1);
                        firsthalf.Remove(firstMax);
                        if (value1 > 1)
                        {
                            firsthalf.Add(firstMax, value1 - 1);
                        }

                        hasValue = secondhalf.TryGetValue(firstMax, out value2);
                        if (hasValue)
                        {
                            secondhalf.Remove(firstMax);
                            secondhalf.Add(firstMax, value2 + 1);
                        }
                        else
                        {
                            secondhalf.Add(firstMax, 1);
                        }
                        secondMin = Math.Min(secondMin, firstMax);
                        if (value1 == 1)
                        {
                            firstMax = firsthalf.MaxBy(k => k.Key).Key;
                        }


                        secondCnt++;
                        firstCnt--;
                    }
                }
            }
            else
            {
                while (secondCnt + 1 != firstCnt)
                {
                    if (secondCnt > firstCnt)
                    {
                        hasValue = secondhalf.TryGetValue(secondMin, out value1);
                        secondhalf.Remove(secondMin);
                        if (value1 > 1)
                        {
                            secondhalf.Add(secondMin, value1 - 1);
                        }

                        hasValue = firsthalf.TryGetValue(secondMin, out value2);
                        if (hasValue)
                        {
                            firsthalf.Remove(secondMin);
                            firsthalf.Add(secondMin, value2 + 1);
                        }
                        else
                        {
                            firsthalf.Add(secondMin, 1);
                        }
                        firstMax = Math.Max(secondMin, firstMax);
                        if (value1 == 1)
                        {
                            secondMin = secondhalf.MinBy(k => k.Key).Key;
                        }


                        secondCnt--;
                        firstCnt++;
                    }
                    else
                    {
                        hasValue = firsthalf.TryGetValue(firstMax, out value1);
                        firsthalf.Remove(firstMax);
                        if (value1 > 1)
                        {
                            firsthalf.Add(firstMax, value1 - 1);
                        }

                        hasValue = secondhalf.TryGetValue(firstMax, out value2);
                        if (hasValue)
                        {
                            secondhalf.Remove(firstMax);
                            secondhalf.Add(firstMax, value2 + 1);
                        }
                        else
                        {
                            secondhalf.Add(firstMax, 1);
                        }
                        secondMin = Math.Min(secondMin, firstMax);
                        if (value1 == 1)
                        {
                            firstMax = firsthalf.MaxBy(k => k.Key).Key;
                        }
                        secondCnt++;
                        firstCnt--;
                    }
                }
            }
        }
        
            /*
            PriorityQueue<int, int> secondhalf = new PriorityQueue<int, int>();
            PriorityQueue<int, int> firsthalf = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            public double[] MedianSlidingWindow(int[] nums, int k)
            {
                double[] ret = new double[nums.Length - k + 1];
                int cnt = 0;
                for(cnt = 0; cnt < k; cnt++)
                {
                    this.AddNum(nums[cnt]);
                }
                ret[0] = FindMedian();


                for (cnt = k; cnt < nums.Length; cnt++)
                {
                }


                return ret;
            }

            private void AddNum(int num)
            {
                int min = secondhalf.Count > 0 ? secondhalf.Peek() : int.MaxValue;

                if (num > min)
                {
                    secondhalf.Enqueue(num, num);
                    if (secondhalf.Count > firsthalf.Count)
                    {
                        int item = secondhalf.Dequeue();
                        firsthalf.Enqueue(item, item);
                    }
                }
                else
                {
                    firsthalf.Enqueue(num, num);
                    if (firsthalf.Count > secondhalf.Count)
                    {
                        int item = firsthalf.Dequeue();
                        secondhalf.Enqueue(item, item);
                    }
                }
            }

            private double FindMedian()
            {
                if (secondhalf.Count > firsthalf.Count)
                {
                    return secondhalf.Peek();
                }
                else if (secondhalf.Count < firsthalf.Count)
                {
                    return firsthalf.Peek();
                }
                else
                {
                    return ((double)secondhalf.Peek() + (double)firsthalf.Peek()) / 2;
                }
            }
            */
        }
}
