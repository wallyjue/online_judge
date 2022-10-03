using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem116
    {
        public Node Connect(Node root)
        {
            List<IList<int>> ret = new List<IList<int>>();
            if (root == null)
            {
                return root;
            }
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Stack<Node> stack = new Stack<Node>();
                int count = queue.Count;
                Node prev = null;
                for (int cnt = 0; cnt < count; cnt++)
                {
                    Node node = queue.Dequeue();
                    if (prev != null)
                    {
                        prev.next = node;
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    prev = node;
                }
            }

            return root;
        }
    }
}
