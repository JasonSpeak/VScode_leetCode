/*
 * @lc app=leetcode.cn id=485 lang=csharp
 *
 * [485] 最大连续1的个数
 *
 * https://leetcode-cn.com/problems/max-consecutive-ones/description/
 *
 * algorithms
 * Easy (55.70%)
 * Likes:    83
 * Dislikes: 0
 * Total Accepted:    28.6K
 * Total Submissions: 51.3K
 * Testcase Example:  '[1,0,1,1,0,1]'
 *
 * 给定一个二进制数组， 计算其中最大连续1的个数。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [1,1,0,1,1,1]
 * 输出: 3
 * 解释: 开头的两位和最后的三位都是连续1，所以最大连续1的个数是 3.
 * 
 * 
 * 注意：
 * 
 * 
 * 输入的数组只包含 0 和1。
 * 输入数组的长度是正整数，且不超过 10,000。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxOnes = 0;
        int tempMaxOnes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                tempMaxOnes++;
            }
            if (nums[i] == 0 || i == nums.Length - 1)
            {
                if (tempMaxOnes > maxOnes)
                    maxOnes = tempMaxOnes;
                tempMaxOnes = 0;
            }
        }
        return maxOnes;
    }
}
// @lc code=end

