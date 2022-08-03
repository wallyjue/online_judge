using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem94
    {
        List<int> route = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            InorderTraverse(root);
            return route;
        }

        private void InorderTraverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node.left != null)
            {
                InorderTraverse(node.left);
            }
            route.Add(node.val);

            if (node.right != null)
            {
                InorderTraverse(node.right);
            }
        }
    }
}
