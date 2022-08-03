using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem144
    {
        List<int> route = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {
            PreorderTraverse(root);

            return route;
        }

        private void PreorderTraverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            route.Add(node.val);
            if (node.left != null)
            {
                PreorderTraverse(node.left);
            }

            if (node.right != null)
            {
                PreorderTraverse(node.right);
            }
        }
    }
}
