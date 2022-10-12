using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem589
    {
        public IList<int> Preorder(Node root)
        {
            List<int> ret = new List<int>();

            if (root == null) return ret;

            
            LinkedList<Node> stack = new LinkedList<Node>();
            stack.AddFirst(root);


            while (stack.Count > 0)
            {
                Node node = stack.First();
                stack.RemoveFirst();
                ret.Add(node.val);

                foreach (Node child in node.children.Reverse())
                {
                    stack.AddFirst(child);
                }
            }


            return ret;
        }
    }
}
