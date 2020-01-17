/*
 * @lc app=leetcode.cn id=434 lang=csharp
 *
 * [434] 字符串中的单词数
 *
 * https://leetcode-cn.com/problems/number-of-segments-in-a-string/description/
 *
 * algorithms
 * Easy (32.60%)
 * Likes:    44
 * Dislikes: 0
 * Total Accepted:    11.2K
 * Total Submissions: 33.6K
 * Testcase Example:  '"Hello, my name is John"'
 *
 * 统计字符串中的单词个数，这里的单词指的是连续的不是空格的字符。
 * 
 * 请注意，你可以假定字符串里不包括任何不可打印的字符。
 * 
 * 示例:
 * 
 * 输入: "Hello, my name is John"
 * 输出: 5
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int CountSegments(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((i == 0 || s[i - 1] == ' ') && s[i] != ' ')
                {
                    count++;
                }
            }

            return count;
    }
}
// @lc code=end

