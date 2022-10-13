using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem733
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            Hashtable table = new Hashtable();
            if (image[sr][sc] != color)
            {
                stack.Push((sr, sc));
            }

            while (stack.Count > 0)
            {
                var item = stack.Pop();

                if (!table.Contains((item.Item1, item.Item2)))
                {
                    table.Add((item.Item1, item.Item2), true);
                }

                if (item.Item1 - 1 >= 0 && !table.Contains((item.Item1 - 1, item.Item2))
                    && image[item.Item1 - 1][item.Item2] == image[item.Item1][item.Item2])
                {
                    stack.Push((item.Item1 - 1, item.Item2));
                }

                if (item.Item1 + 1 < image.Length && !table.Contains((item.Item1 + 1, item.Item2))
                    && image[item.Item1 + 1][item.Item2] == image[item.Item1][item.Item2])
                {
                    stack.Push((item.Item1 + 1, item.Item2));
                }

                if (item.Item2 - 1 >= 0 && !table.Contains((item.Item1, item.Item2 - 1))
                    && image[item.Item1][item.Item2 - 1] == image[item.Item1][item.Item2])
                {
                    stack.Push((item.Item1, item.Item2 - 1));
                }

                if (item.Item2 + 1 < image[0].Length && !table.Contains((item.Item1, item.Item2 + 1))
                    && image[item.Item1][item.Item2 + 1] == image[item.Item1][item.Item2])
                {
                    stack.Push((item.Item1, item.Item2 + 1));
                }

                
                image[item.Item1][item.Item2] = color;
            }

            return image;
        }
    }
}
