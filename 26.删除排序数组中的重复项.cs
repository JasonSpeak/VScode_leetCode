/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除排序数组中的重复项
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
            {
                return 0;
            }

            int i = 0;
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[i + 1] = nums[j];
                    i = i + 1;
                }
            }

            return i + 1;
    }
}
// @lc code=end

