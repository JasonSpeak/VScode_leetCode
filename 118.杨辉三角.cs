/*
 * @lc app=leetcode.cn id=118 lang=csharp
 *
 * [118] 杨辉三角
 *
 * https://leetcode-cn.com/problems/pascals-triangle/description/
 *
 * algorithms
 * Easy (64.52%)
 * Likes:    209
 * Dislikes: 0
 * Total Accepted:    49.9K
 * Total Submissions: 76.8K
 * Testcase Example:  '5'
 *
 * 给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
 * 
 * 
 * 
 * 在杨辉三角中，每个数是它左上方和右上方的数的和。
 * 
 * 示例:
 * 
 * 输入: 5
 * 输出:
 * [
 * ⁠    [1],
 * ⁠   [1,1],
 * ⁠  [1,2,1],
 * ⁠ [1,3,3,1],
 * ⁠[1,4,6,4,1]
 * ]
 * 
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows == 0)
        {
            return new List<IList<int>>();
        }

        if (numRows == 1)
        {
            return new List<IList<int>>() { new List<int>() { 1 } };
        }

        if (numRows == 2)
        {
            return new List<IList<int>>() { new List<int>() { 1 }, new List<int>() { 1, 1 } };
        }

        List<IList<int>> result = new List<IList<int>>() { new List<int>() { 1 }, new List<int>() { 1, 1 } };
        for (var i = 2; i < numRows; i++)
        {
            IList<int> tempLevel = new List<int>();
            tempLevel.Add(1);
            for (int j = 1; j < i; j++)
            {
                tempLevel.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }

            tempLevel.Add(1);
            result.Add(tempLevel);
        }

        return result;
    }
}
// @lc code=end

