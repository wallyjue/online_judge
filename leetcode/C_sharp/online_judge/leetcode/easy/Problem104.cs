using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root != null)
            {
                Math.Max(MaxDepth(root.left), MaxDepth(root.right));
            }
            else
            {
                return 1;
            }
        }
    }
}
