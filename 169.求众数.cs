/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 求众数
 *
 * https://leetcode-cn.com/problems/majority-element/description/
 *
 * algorithms
 * Easy (60.47%)
 * Likes:    400
 * Dislikes: 0
 * Total Accepted:    96.2K
 * Total Submissions: 157.7K
 * Testcase Example:  '[3,2,3]'
 *
 * 给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。
 * 
 * 你可以假设数组是非空的，并且给定的数组总是存在多数元素。
 * 
 * 示例 1:
 * 
 * 输入: [3,2,3]
 * 输出: 3
 * 
 * 示例 2:
 * 
 * 输入: [2,2,1,1,1,2,2]
 * 输出: 2
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        int countFlag = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (countFlag == 0)
                {
                    result = nums[i];
                }
                countFlag += (result == nums[i]) ? 1 : -1;
            }
            return result;
    }
}
// @lc code=end

