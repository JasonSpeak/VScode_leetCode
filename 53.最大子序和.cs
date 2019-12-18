/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        int ans = nums[0];
            int sum = 0;
            foreach (var num in nums)
            {
                if (sum > 0)
                {
                    sum += num;
                }
                else
                {
                    sum = num;
                }

                ans = ans > sum ? ans : sum;
            }
            return ans;
    }
}
// @lc code=end

