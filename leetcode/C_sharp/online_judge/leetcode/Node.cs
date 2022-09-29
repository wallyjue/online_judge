namespace online_judge.leetcode
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node prev;
        public Node child;

        public Node random;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }

        public Node(int _val, Node _prev, Node _next, Node _child, Node _left)
        {
            val = _val;
            prev = _prev;
            next = _next;
            child = _child;
        }
    }
}
