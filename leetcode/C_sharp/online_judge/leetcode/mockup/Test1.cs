using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.mockup
{
    internal class Test1
    {
        Dictionary<TreeNode, TreeNode> parents = new Dictionary<TreeNode, TreeNode>();
        Dictionary<TreeNode, int> levels = new Dictionary<TreeNode, int>();
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            BFS(root);
            TreeNode ret = null;
            
            int prevlevel = -1;
            foreach (var level in levels.OrderByDescending(x => x.Value))
            {
                if (level.Value <= prevlevel)
                {
                    break;
                }

                var leafs = levels.Where(x => x.Value == level.Value).Select(y => y);
                foreach (var leaf in leafs)
                {
                    if (ret == null)
                    {
                        ret = leaf.Key;
                    }
                    else
                    {
                        // find parent of ret and leaf
                        Hashtable hashparents = new Hashtable();
                        TreeNode ptr = ret;
                        while(ptr != null)
                        {
                            hashparents.Add(ptr, ptr);
                            ptr = parents[ptr];
                        }

                        ptr = leaf.Key;
                        while (ptr != null)
                        {
                            if (hashparents.Contains(ptr))
                            {
                                ret = ptr;
                                break;
                            }

                            ptr = parents[ptr];
                        }
                    }
                }

                prevlevel = level.Value;
            }
            return ret;
        }

        private void BFS(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode node = queue.Dequeue();

            int level = 0;
            parents.Add(node, null);
            levels.Add(node, level);

            while (node != null)
            {
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    parents.Add(node.left, node);
                    levels.Add(node.left, levels[node] + 1);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    parents.Add(node.right, node);
                    levels.Add(node.right, levels[node] + 1);
                }

                if (queue.Count > 0)
                {
                    node = queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
        }


        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            List<int> ret = new List<int>();
            if (nums1.Length > nums2.Length)
            {
                for (int cnt = 0; cnt < nums2.Length; cnt++)
                {
                    table.Add(cnt, nums2[cnt]);
                }

                for (int cnt = 0; cnt < nums1.Length;cnt++)
                {
                    if (table.ContainsValue(nums1[cnt]))
                    {
                        var items = table.Where(x => x.Value == nums1[cnt]).Select(x => x);
                        if (items.Count() > 0)
                        {
                            ret.Add(items.First().Value);
                            foreach (var item in items)
                            {
                                table.Remove(item.Key);
                            }
                        }
                    }
                }
            }
            else
            {
                for (int cnt = 0; cnt < nums1.Length; cnt++)
                {
                    table.Add(cnt, nums1[cnt]);
                }

                for (int cnt = 0; cnt < nums2.Length; cnt++)
                {
                    if (table.ContainsValue(nums2[cnt]))
                    {
                        var items = table.Where(x => x.Value == nums2[cnt]).Select(x => x);
                        if (items.Count() > 0)
                        {
                            ret.Add(items.First().Value);
                            foreach(var item in items)
                            {
                                table.Remove(item.Key);
                            }
                        }
                    }
                }
            }

            return ret.ToArray();
        }
    }
}
