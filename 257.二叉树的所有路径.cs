/*
 * @lc app=leetcode.cn id=257 lang=csharp
 *
 * [257] 二叉树的所有路径
 *
 * https://leetcode-cn.com/problems/binary-tree-paths/description/
 *
 * algorithms
 * Easy (60.42%)
 * Likes:    184
 * Dislikes: 0
 * Total Accepted:    21.9K
 * Total Submissions: 35.6K
 * Testcase Example:  '[1,2,3,null,5]'
 *
 * 给定一个二叉树，返回所有从根节点到叶子节点的路径。
 * 
 * 说明: 叶子节点是指没有子节点的节点。
 * 
 * 示例:
 * 
 * 输入:
 * 
 * ⁠  1
 * ⁠/   \
 * 2     3
 * ⁠\
 * ⁠ 5
 * 
 * 输出: ["1->2->5", "1->3"]
 * 
 * 解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3
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
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        IList<string> res = new List<string>();
        ConstructPaths(root, "", res);
        return res;
    }

    private void ConstructPaths(TreeNode root, string path, IList<string> paths)
    {
        if (root != null)
        {
            path += root.val.ToString();
            if (root.left == null && root.right == null)
            {
                paths.Add(path);
            }
            else
            {
                path += "->";
                ConstructPaths(root.left, path, paths);
                ConstructPaths(root.right, path, paths);
            }
        }
    }
}
// @lc code=end

