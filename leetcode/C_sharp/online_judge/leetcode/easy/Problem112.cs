using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            TreeNode runner = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<int> sum = new Stack<int>();
            stack.Push(runner);
            sum.Push(targetSum - runner.val);

            while (stack.Count > 0)
            {
                runner = stack.Pop();
                int temp = sum.Pop();
                if (runner.left == null && runner.right == null && temp == 0)
                {
                    return true;
                }
                    

                if (runner.right != null)
                {
                    stack.Push(runner.right);
                    sum.Push(temp - runner.right.val);
                }

                if (runner.left != null)
                {
                    stack.Push(runner.left);
                    sum.Push(temp - runner.left.val);
                }
            }
            return false;
        }

    }
}
