package com.leetcode.wallyjue.easy;

import com.leetcode.wallyjue.TreeNode;

import java.util.LinkedList;

public class Problem872 {
    public boolean leafSimilar(TreeNode root1, TreeNode root2) {
        LinkedList<Integer> nodes1 = dfs(root1);
        LinkedList<Integer> nodes2 = dfs(root2);
        if (nodes1.size() != nodes2.size()) return false;
        while (!nodes1.isEmpty())
            if (nodes1.remove() != nodes2.remove()) return false;

        return true;
    }

    private LinkedList<Integer> dfs(TreeNode root) {
        LinkedList<Integer> ret = new LinkedList<>();
        LinkedList<TreeNode> nodes = new LinkedList<>();
        nodes.push(root);
        while (!nodes.isEmpty()) {
            TreeNode node = nodes.pop();
            if (node.left != null)
                nodes.push(node.left);

            if (node.right != null)
                nodes.push(node.right);

            if (node.left == null && node.right == null)
                ret.push(node.val);
        }
        return ret;
    }
}
