using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem103
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> ret = new List<IList<int>>();
            if (root == null)
            {
                return ret;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            bool leftToRight = true;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                LinkedList<int> layer = new LinkedList<int>();
                int count = queue.Count;
                for (int cnt = 0; cnt < count; cnt++)
                {
                    TreeNode node = queue.Dequeue();
                    if (leftToRight)
                    {
                        layer.AddLast(node.val);
                    }
                    else
                    {
                        layer.AddFirst(node.val);
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                leftToRight = !leftToRight;
                ret.Add(layer.ToList());
            }

            return ret;
        }
    }
}
