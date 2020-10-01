/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    // Iterative method
    public int MaxDepth(TreeNode root) {
        TreeNode node = root;
        
        Stack<TreeNode> nodeStack = new Stack<TreeNode>();
        Stack<int> depthStack = new Stack<int>();
        
        int max = 0;
        int depth = 1;
        
        while (node != null || nodeStack.Count() != 0) {
            if (node != null) {
                nodeStack.Push(node);
                depthStack.Push(depth);
                node = node.left;
                depth++;
            }
            else {
                node = nodeStack.Pop();
                depth = depthStack.Pop();
                if (depth > max) {
                    max = depth;
                }
                node = node.right;
                depth++;
            }
        }
        
        return max;
    }
    
    // Recursive method
    /*
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        return 1+Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
    */
}
// @lc code=end

