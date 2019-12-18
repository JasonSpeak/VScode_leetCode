/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m + n - 1;
        int j = m - 1;
        int k = n - 1;
        while (j >= 0 && k >= 0)
        {
            nums1[i--] = nums1[j] >= nums2[k] ? nums1[j--] : nums2[k--];
        }

        if (j < 0)
        {
            while (k >= 0)
            {
                nums1[i--] = nums2[k--];
            }
        }
    }
}
// @lc code=end

