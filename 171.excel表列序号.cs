/*
 * @lc app=leetcode.cn id=171 lang=csharp
 *
 * [171] Excel表列序号
 *
 * https://leetcode-cn.com/problems/excel-sheet-column-number/description/
 *
 * algorithms
 * Easy (65.42%)
 * Likes:    102
 * Dislikes: 0
 * Total Accepted:    27.7K
 * Total Submissions: 42K
 * Testcase Example:  '"A"'
 *
 * 给定一个Excel表格中的列名称，返回其相应的列序号。
 * 
 * 例如，
 * 
 * ⁠   A -> 1
 * ⁠   B -> 2
 * ⁠   C -> 3
 * ⁠   ...
 * ⁠   Z -> 26
 * ⁠   AA -> 27
 * ⁠   AB -> 28 
 * ⁠   ...
 * 
 * 
 * 示例 1:
 * 
 * 输入: "A"
 * 输出: 1
 * 
 * 
 * 示例 2:
 * 
 * 输入: "AB"
 * 输出: 28
 * 
 * 
 * 示例 3:
 * 
 * 输入: "ZY"
 * 输出: 701
 * 
 * 致谢：
 * 特别感谢 @ts 添加此问题并创建所有测试用例。
 * 
 */

// @lc code=start
public class Solution {
    public int TitleToNumber(string s) {
        var baseMap = new Hashtable();
             for (int i = 0; i < 26; i++)
             {
                 baseMap.Add((char)('A' + i), i + 1);
             }

             int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result += (int)Math.Pow(26, s.Length - 1 - i)*(int)baseMap[s[i]];
            }

            return result;
    }
}
// @lc code=end

