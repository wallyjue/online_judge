using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem700
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null && root.val != val)
            {
                if (val == root.val)
                {
                    return root;
                }
                else if (val > root.val)
                {
                    root = root.right;
                }
                else if (val < root.val)
                {
                    root = root.left;
                }
            }
            return root;
        }
    }
}
