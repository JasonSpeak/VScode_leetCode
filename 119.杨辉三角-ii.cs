/*
 * @lc app=leetcode.cn id=119 lang=csharp
 *
 * [119] 杨辉三角 II
 *
 * https://leetcode-cn.com/problems/pascals-triangle-ii/description/
 *
 * algorithms
 * Easy (58.68%)
 * Likes:    97
 * Dislikes: 0
 * Total Accepted:    32.3K
 * Total Submissions: 54.7K
 * Testcase Example:  '3'
 *
 * 给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。
 * 
 * 
 * 
 * 在杨辉三角中，每个数是它左上方和右上方的数的和。
 * 
 * 示例:
 * 
 * 输入: 3
 * 输出: [1,3,3,1]
 * 
 * 
 * 进阶：
 * 
 * 你可以优化你的算法到 O(k) 空间复杂度吗？
 * 
 */

// @lc code=start
public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        if (rowIndex == 0)
        {
            return new List<int>() { 1 };
        }

        if (rowIndex == 1)
        {
            return new List<int>() { 1, 1 };
        }


        List<int> preLevel = new List<int>() { 1, 1 };
        List<int> currentLevel = new List<int>();
        for (int i = 2; i < rowIndex + 1; i++)
        {
            currentLevel = new List<int>();
            currentLevel.Add(1);
            for (int j = 1; j < i; j++)
            {
                currentLevel.Add(preLevel[j - 1] + preLevel[j]);
            }
            currentLevel.Add(1);
            preLevel = new List<int>(currentLevel);
        }

        return currentLevel;
    }
}
// @lc code=end

