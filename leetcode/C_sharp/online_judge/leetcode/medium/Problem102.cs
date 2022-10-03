using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> ret = new List<IList<int>>();
            if (root == null)
            {
                return ret;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                List<int> layer = new List<int>();
                int count = queue.Count;
                for (int cnt = 0; cnt < count; cnt++)
                {
                    TreeNode node = queue.Dequeue();
                    layer.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                ret.Add(layer);
            }

            return ret;
        }
    }
}
