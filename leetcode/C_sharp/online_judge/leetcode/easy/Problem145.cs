using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem145
    {
        List<int> route = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            PostorderTraverse(root);
            return route;
        }

        private void PostorderTraverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null)
            {
                PostorderTraverse(node.left);
            }
            if (node.right != null)
            {
                PostorderTraverse(node.right);
            }

            route.Add(node.val);
        }
    }
}
