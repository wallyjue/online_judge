using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem314
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            List<IList<int>> ret = new List<IList<int>>();
            Dictionary<int, IList<int>> lists = new Dictionary<int, IList<int>>();
            Hashtable table = new Hashtable();
            if (root == null)
            {
                return ret;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int cnt = 0; cnt < count; cnt++)
                {
                    TreeNode node = queue.Dequeue();

                    int nodeXaxis = 0; 
                    if (table.ContainsKey(node))
                    {
                        nodeXaxis = (int)table[node];
                    }
                    else
                    {
                        table.Add(node, nodeXaxis);
                    }
                    
                    lists.TryGetValue(nodeXaxis, out var list);
                    if (list == null)
                    {
                        list = new List<int>() { node.val };
                        lists.Add(nodeXaxis, list);
                    }
                    else
                    {
                        list.Add(node.val);
                        lists.Remove(nodeXaxis);
                        lists.Add(nodeXaxis, list);
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);

                        table.Add(node.left, nodeXaxis - 1);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);

                        table.Add(node.right, nodeXaxis + 1);
                    }
                }
            }
            SortedDictionary<int, IList<int>> ordered = new SortedDictionary<int, IList<int>>(lists);
            ret = ordered.Select(x => x.Value).ToList();
            return ret;
        }


    }
}
