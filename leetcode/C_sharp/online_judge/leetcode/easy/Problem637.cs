using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> ret = new List<double>();

            //List<IList<int>> ret = new List<IList<int>>();
            if (root == null)
            {
                return ret;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                long layerSum = 0;
                int count = queue.Count;
                for (int cnt = 0; cnt < count; cnt++)
                {
                    TreeNode node = queue.Dequeue();
                    layerSum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                double ave = (double)(layerSum / (double)count);
                ret.Add(ave);
            }

            return ret;
        }
    }
}
