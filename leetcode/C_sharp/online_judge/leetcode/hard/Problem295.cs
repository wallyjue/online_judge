using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class MedianFinder
    {
        /*
        bool isSorted;
        List<int> list = new List<int>();
        List<int> temp;
        
        public MedianFinder()
        {
            isSorted = true;
        }

        public void AddNum(int num)
        {
            isSorted = false;
            if (list.Count > 0)
            {
                if (list[0] > num)
                {
                    temp = new List<int> { num };
                    temp.AddRange(list);
                    list = temp;
                    isSorted = true;
                }
                else if (list[list.Count - 1] < num)
                {
                    list.Add(num);
                    isSorted = true;
                }
                else
                {
                    list.Add(num);
                }
            }
            else
            {
                list.Add(num);
            }
        }

        public double FindMedian()
        {
            if (!isSorted)
            {
                list.Sort();
                isSorted = true;
            }

            int count = list.Count;
            if (count % 2 == 0)
            {
                int index1 = (count - 1) / 2;
                int index2 = ((count - 1) / 2) + 1;
                double ret = ((double)list[(count - 1) / 2] + (double)list[((count - 1) / 2) + 1]) / 2;
                return ret;
            }
            else
            {
                return list[count / 2];
            }
        }
        */

        PriorityQueue<int, int> secondhalf;
        PriorityQueue<int, int> firsthalf;
        public MedianFinder()
        {
            secondhalf = new PriorityQueue<int, int>();
            firsthalf = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        }

        public void AddNum(int num)
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

        public double FindMedian()
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
    }
}
