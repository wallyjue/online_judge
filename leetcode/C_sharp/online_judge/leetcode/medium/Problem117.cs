using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem117
    {
        Hashtable table = new Hashtable();
        public Node Connect(Node root)
        {
            dfs(root, 0);
            return root;
        }

        private void dfs(Node node, int layer)
        {
            if (node.right != null)
            {
                dfs(node.right, layer + 1);
            }

            if (table[layer] == null)
            {
                table[layer] = node;
                node.next = null;
            }
            else
            {
                node.next = (Node)table[layer];
                table[layer] = node;
            }

            if (node.left != null)
            {
                dfs(node.left, layer + 1);
            }
        }
    }
}
