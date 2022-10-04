using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem138
    {
        Dictionary<Node, Node> table = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node runner = head;

            // Creating the new head node.
            Node newNode = new Node(runner.val);
            this.table.Add(runner, newNode);

            while (runner != null)
            {
                newNode.next = this.getNode(runner.next);
                newNode.random = this.getNode(runner.random);

                runner = runner.next;
                newNode = newNode.next;
            }

            return this.getNode(head);
        }

        private Node getNode(Node node)
        {
            if (node == null) return null;

            if (this.table.ContainsKey(node))
            {
                return this.table[node];
            }
            else
            {
                Node temp = new Node(node.val);

                this.table.Add(node, temp);
                return temp;
            }
        }
    }
}
