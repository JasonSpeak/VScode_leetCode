/*
 * @lc app=leetcode.cn id=404 lang=csharp
 *
 * [404] 左叶子之和
 *
 * https://leetcode-cn.com/problems/sum-of-left-leaves/description/
 *
 * algorithms
 * Easy (52.57%)
 * Likes:    112
 * Dislikes: 0
 * Total Accepted:    14.8K
 * Total Submissions: 28K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * 计算给定二叉树的所有左叶子之和。
 * 
 * 示例：
 * 
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 在这个二叉树中，有两个左叶子，分别是 9 和 15，所以返回 24
 * 
 * 
 * 
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int sum = 0;
        if (root.left != null && (root.left.left == null && root.left.right == null))
        {
            sum += root.left.val;
        }
        else
        {
            sum += SumOfLeftLeaves(root.left);
        }

        sum += SumOfLeftLeaves(root.right);
        return sum;
    }
}
// @lc code=end

