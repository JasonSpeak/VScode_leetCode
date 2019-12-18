/*
 * @lc app=leetcode.cn id=107 lang=csharp
 *
 * [107] 二叉树的层次遍历 II
 *
 * https://leetcode-cn.com/problems/binary-tree-level-order-traversal-ii/description/
 *
 * algorithms
 * Easy (62.98%)
 * Likes:    162
 * Dislikes: 0
 * Total Accepted:    33.9K
 * Total Submissions: 53.5K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * 给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）
 * 
 * 例如：
 * 给定二叉树 [3,9,20,null,null,15,7],
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 
 * 返回其自底向上的层次遍历为：
 * 
 * [
 * ⁠ [15,7],
 * ⁠ [9,20],
 * ⁠ [3]
 * ]
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
public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        Queue<TreeNode> tempQueue = new Queue<TreeNode>();
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            tempQueue.Enqueue(root);
            while (tempQueue.Count!=0)
            {
                IList<int> currentLevel = new List<int>();
                int n = tempQueue.Count;
                for (int i = 0; i < n; i++)
                {
                    TreeNode node = tempQueue.Dequeue();
                    currentLevel.Add(node.val);
                    if(node.left!=null)
                        tempQueue.Enqueue(node.left);
                    if (node.right != null)
                        tempQueue.Enqueue(node.right);
                }
                result.Add(currentLevel);
            }
            result = result.Reverse().ToList();
            return result;
    }
}
// @lc code=end

