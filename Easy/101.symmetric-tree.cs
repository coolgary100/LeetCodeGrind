/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
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
    // Iterative Solution
    public bool IsSymmetric(TreeNode root) {
        if (root == null) {
            return true;
        }    
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        while (queue.Count != 0)
        {
            TreeNode left = queue.Dequeue();
            TreeNode right = queue.Dequeue();
            if (left == null && right == null) {
                continue;
            }
            if (left == null || right == null || left.val != right.val ) {
                return false;
            }
            else {
                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);
            }         
        }
        
        return true;
    }
    
    // Recursive Solution
    /*public bool IsSymmetric(TreeNode root) {
        if (root == null) {
            return true;
        }
        return IsSubTreeSymmetric(root.left, root.right);
    }
    
    private bool IsSubTreeSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) {
            return true;
        }
        if (left == null || right == null) {
            return false;
        }
        if (left.val == right.val) {
            return IsSubTreeSymmetric(left.left, right.right) && IsSubTreeSymmetric(left.right, right.left);
        }
        else {
            return false;
        }
        
    }*/
}
// @lc code=end

