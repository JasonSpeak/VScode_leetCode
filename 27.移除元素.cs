/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0)
            {
                return 0;
            }

            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            return i;
    }
}
// @lc code=end

