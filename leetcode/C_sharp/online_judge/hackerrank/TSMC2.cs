using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.hackerrank
{
    internal class TSMC2
    {
        public int bestSumKStar(int gNodes, List<int> gFrom, List<int> gTo, List<int> values, int k)
        {
            List<List<int>> lists = new List<List<int>>();
            List<int> list = null;
            for (int cnt =0; cnt < gNodes;cnt++)
            {
                list = new List<int>();
                lists.Add(list);
            }
            for (int edgeCnt = 0; edgeCnt < gFrom.Count; edgeCnt++)
            {
                list = (List<int>)lists[gFrom[edgeCnt]];
                list.Add(gTo[edgeCnt]);

                list = (List<int>)lists[gTo[edgeCnt]];
                list.Add(gFrom[edgeCnt]);
            }


            int maxSum = int.MinValue;
            for (int node = 0; node < gNodes;node++)
            {
                int tempSum = values[node];
                list = lists[node];
                List<int> valuelist = new List<int>();
                for (int cnt = 0; cnt < list.Count;cnt++)
                {
                    valuelist.Add(values[list[cnt]]);
                }
                valuelist.Sort((a, b) => b.CompareTo(a));
                for (int cnt = 0; cnt < k && cnt < list.Count; cnt++)
                {
                    if (valuelist[cnt] + tempSum >= tempSum)
                    {
                        tempSum += valuelist[cnt];
                    }
                }
                maxSum = Math.Max(maxSum, tempSum);
            }

            return maxSum;
        }

        public List<string> sortRoman(List<string> names)
        {
            List<string> ret = new List<string>();
            Dictionary<string, List<int>> table = new Dictionary<string, List<int>>();

            foreach(string nameWithTitle in names)
            {
                string[] nameAndTitle = nameWithTitle.Split(' ');
                if (!table.ContainsKey(nameAndTitle[0]))
                {
                    //table.Add(nameAndTitle[0], new List<int> { RomanToInt(nameAndTitle[1]) });
                }
                else
                {

                }
            }

            return ret;
        }

        // dp 
        // f[n] = (f[n-1].reverse, nums[n])
        public List<int> applyOperations2(List<int> arr)
        {
            if (arr.Count == 1) return arr;
            if (arr.Count == 2) return new List<int> { arr[0], arr[1] };

            List<int> lastList = new List<int> { arr[0], arr[1] };

            for (int cnt = 2; cnt < arr.Count;cnt++)
            {
                lastList.Reverse();
                lastList.Add(arr[cnt]);
            }

            return lastList;
        }

        public List<int> applyOperations(List<int> arr)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            foreach(int num in arr)
            {
                // step 1.
                while (stack.Count > 0)
                {
                    var item = stack.Pop();
                    queue.Enqueue(item);
                }

                // step 2. 
                stack.Push(num);

                // step 3.
                while (queue.Count > 0)
                {
                    var item = queue.Dequeue();
                    stack.Push(item);
                }
            }

            return stack.ToList();
        }
    }
}
