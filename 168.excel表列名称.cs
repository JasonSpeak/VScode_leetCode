/*
 * @lc app=leetcode.cn id=168 lang=csharp
 *
 * [168] Excel表列名称
 *
 * https://leetcode-cn.com/problems/excel-sheet-column-title/description/
 *
 * algorithms
 * Easy (35.31%)
 * Likes:    157
 * Dislikes: 0
 * Total Accepted:    17.1K
 * Total Submissions: 47.5K
 * Testcase Example:  '1'
 *
 * 给定一个正整数，返回它在 Excel 表中相对应的列名称。
 * 
 * 例如，
 * 
 * ⁠   1 -> A
 * ⁠   2 -> B
 * ⁠   3 -> C
 * ⁠   ...
 * ⁠   26 -> Z
 * ⁠   27 -> AA
 * ⁠   28 -> AB 
 * ⁠   ...
 * 
 * 
 * 示例 1:
 * 
 * 输入: 1
 * 输出: "A"
 * 
 * 
 * 示例 2:
 * 
 * 输入: 28
 * 输出: "AB"
 * 
 * 
 * 示例 3:
 * 
 * 输入: 701
 * 输出: "ZY"
 * 
 * 
 */

// @lc code=start
public class Solution {
    public string ConvertToTitle(int n) {
        StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                int c = n % 26;
                if (c == 0)
                {
                    c = 26;
                    n -= 1;
                }
                sb.Insert(0, (char)('A' + c - 1));
                n /= 26;
            }
            return sb.ToString();
    }
}
// @lc code=end

