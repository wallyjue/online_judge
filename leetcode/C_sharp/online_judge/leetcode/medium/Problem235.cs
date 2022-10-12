using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem235
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode ret = null;
            var list1 = traverse(root, p);
            var list2 = traverse(root, q);

            list1.Reverse();
            foreach(var item in list1)
            {
                ret = list2.FirstOrDefault(x => x.val == item.val);
                if (ret != null) return ret;
            }
            return ret;
        }

        private List<TreeNode> traverse(TreeNode start, TreeNode target)
        {
            List<TreeNode> list = new List<TreeNode>();
            while (start != null)
            {
                list.Add(start);

                if (start.val == target.val)
                {
                    return list;
                }

                if (start.left != null && target.val < start.val)
                {
                    start = start.left;
                }

                if (start.right != null && target.val > start.val)
                {
                    start = start.right;
                }
            }

            return list;
        }
    }
}
