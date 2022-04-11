using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.explore
{
    internal class RecursionII
    {
        public int[] SortArray(int[] nums)
        {
            return merge_sort(nums);
        }

        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;


            return Validate(root, int.MinValue, int.MaxValue);
        }

        private bool Validate(TreeNode node, int lower, int higher)
        {
            if (node == null) return true;

            if (node.val <= lower || node.val >= higher) return false;

            return Validate(node.left, lower, node.val) && Validate(node.right, node.val, higher);
        }

        private int[] merge_sort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }

            int pivot = nums.Length / 2;
            int[] left = new int[nums.Length/2]; 
            int[] right = new int[nums.Length - pivot];
            Array.Copy(nums, 0, left, 0, pivot);
            Array.Copy(nums, pivot, right, 0, right.Length);
            var left_ret = merge_sort(left);
            var right_ret = merge_sort(right);
            return merge(left_ret, right_ret);
        }

        private int[] merge(int[] left, int[] right)
        {
            int[] ret = new int[left.Length+ right.Length];
            int left_ptr = 0, right_ptr = 0, ret_ptr = 0;
            while(left_ptr < left.Length && right_ptr < right.Length)
            {
                if(left[left_ptr] < right[right_ptr])
                {
                    ret[ret_ptr++] = left[left_ptr++];
                }
                else
                {
                    ret[ret_ptr++] = right[right_ptr++];
                }
            }

            while(left_ptr < left.Length)
            {
                ret[ret_ptr++] = left[left_ptr++];
            }

            while (right_ptr < right.Length)
            {
                ret[ret_ptr++] = right[right_ptr++];
            }

            return ret;
        }
    }
}
