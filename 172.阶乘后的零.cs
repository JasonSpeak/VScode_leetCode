/*
 * @lc app=leetcode.cn id=172 lang=csharp
 *
 * [172] 阶乘后的零
 *
 * https://leetcode-cn.com/problems/factorial-trailing-zeroes/description/
 *
 * algorithms
 * Easy (39.54%)
 * Likes:    184
 * Dislikes: 0
 * Total Accepted:    24.3K
 * Total Submissions: 61.6K
 * Testcase Example:  '3'
 *
 * 给定一个整数 n，返回 n! 结果尾数中零的数量。
 * 
 * 示例 1:
 * 
 * 输入: 3
 * 输出: 0
 * 解释: 3! = 6, 尾数中没有零。
 * 
 * 示例 2:
 * 
 * 输入: 5
 * 输出: 1
 * 解释: 5! = 120, 尾数中有 1 个零.
 * 
 * 说明: 你算法的时间复杂度应为 O(log n) 。
 * 
 */

// @lc code=start
public class Solution {
    public int TrailingZeroes(int n) {
        int fiveCount = 0;
            while (n > 0)
            {
                fiveCount += n / 5;
                n = n / 5;
            }

            return fiveCount;
    }
}
// @lc code=end

