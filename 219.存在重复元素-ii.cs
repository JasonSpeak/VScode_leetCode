/*
 * @lc app=leetcode.cn id=219 lang=csharp
 *
 * [219] 存在重复元素 II
 *
 * https://leetcode-cn.com/problems/contains-duplicate-ii/description/
 *
 * algorithms
 * Easy (36.24%)
 * Likes:    127
 * Dislikes: 0
 * Total Accepted:    30.2K
 * Total Submissions: 81.6K
 * Testcase Example:  '[1,2,3,1]\n3'
 *
 * 给定一个整数数组和一个整数 k，判断数组中是否存在两个不同的索引 i 和 j，使得 nums [i] = nums [j]，并且 i 和 j
 * 的差的绝对值最大为 k。
 * 
 * 示例 1:
 * 
 * 输入: nums = [1,2,3,1], k = 3
 * 输出: true
 * 
 * 示例 2:
 * 
 * 输入: nums = [1,0,1,1], k = 1
 * 输出: true
 * 
 * 示例 3:
 * 
 * 输入: nums = [1,2,3,1,2,3], k = 2
 * 输出: false
 * 
 */

// @lc code=start
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length < 2)
        {
            return false;
        }
        var kv = new Hashtable();
        int res = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (kv.ContainsKey(nums[i]))
            {
                res = i - (int)kv[nums[i]];
                if (res <= k)
                {
                    return true;
                }
                kv[nums[i]] = i;
            }
            else
            {
                kv.Add(nums[i], i);
            }
        }

        return false;
    }
}
// @lc code=end

