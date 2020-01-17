/*
 * @lc app=leetcode.cn id=414 lang=csharp
 *
 * [414] 第三大的数
 *
 * https://leetcode-cn.com/problems/third-maximum-number/description/
 *
 * algorithms
 * Easy (33.08%)
 * Likes:    92
 * Dislikes: 0
 * Total Accepted:    17.3K
 * Total Submissions: 50.9K
 * Testcase Example:  '[3,2,1]'
 *
 * 给定一个非空数组，返回此数组中第三大的数。如果不存在，则返回数组中最大的数。要求算法时间复杂度必须是O(n)。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [3, 2, 1]
 * 
 * 输出: 1
 * 
 * 解释: 第三大的数是 1.
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: [1, 2]
 * 
 * 输出: 2
 * 
 * 解释: 第三大的数不存在, 所以返回最大的数 2 .
 * 
 * 
 * 示例 3:
 * 
 * 
 * 输入: [2, 2, 3, 1]
 * 
 * 输出: 1
 * 
 * 解释: 注意，要求返回第三大的数，是指第三大且唯一出现的数。
 * 存在两个值为2的数，它们都排第二。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int ThirdMax(int[] nums)
    {
        int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue, n = nums.Length, cnt = 0;
        for (int i = 0; i < n; i++)
        {
            max1 = Math.Max(max1, nums[i]);
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != max1) max2 = Math.Max(max2, nums[i]);
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != max1 && nums[i] != max2)
            {
                if (nums[i] >= max3)
                {
                    max3 = nums[i];
                    cnt++;
                }
            }
        }
        return (cnt == 0) ? max1 : max3;
    }
}
// @lc code=end

