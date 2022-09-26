using online_judge.leetcode.easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace online_judge.leetcode.medium
{
    internal class Problem430
    {
        public Node Flatten(Node head)
        {
            if (head == null) return head;

            Node pseudoHead = new Node(0, null, head, null);
            Stack<Node> stack = new Stack<Node>();
            Node curr, prev = pseudoHead;
            stack.Push(head);

            while(stack.Count > 0)
            {
                curr = stack.Pop();
                curr.prev = prev;
                prev.next = curr;

                if (curr.next != null) stack.Push(curr.next);

                if (curr.child != null) stack.Push(curr.child);

                curr.child = null;

                prev = curr;
            }

            pseudoHead.next.prev = null;

            return pseudoHead.next;
        }


    }
}
