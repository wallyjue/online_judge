using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem110
    {
        // Recursively obtain the height of a tree. An empty tree has -1 height
        private int Height(TreeNode root)
        {
            // An empty tree has height -1
            if (root == null)
            {
                return -1;
            }
            return 1 + Math.Max(Height(root.left), Height(root.right));
        }

        public bool IsBalanced(TreeNode root)
        {
            // An empty tree satisfies the definition of a balanced tree
            if (root == null)
            {
                return true;
            }

            // Check if subtrees have height within 1. If they do, check if the
            // subtrees are balanced
            return Math.Abs(Height(root.left) - Height(root.right)) < 2
                && IsBalanced(root.left)
                && IsBalanced(root.right);
        }
    }
}
