/*
 * @lc app=leetcode.cn id=389 lang=csharp
 *
 * [389] 找不同
 *
 * https://leetcode-cn.com/problems/find-the-difference/description/
 *
 * algorithms
 * Easy (59.24%)
 * Likes:    103
 * Dislikes: 0
 * Total Accepted:    19.5K
 * Total Submissions: 32.2K
 * Testcase Example:  '"abcd"\n"abcde"'
 *
 * 给定两个字符串 s 和 t，它们只包含小写字母。
 * 
 * 字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。
 * 
 * 请找出在 t 中被添加的字母。
 * 
 * 
 * 
 * 示例:
 * 
 * 输入：
 * s = "abcd"
 * t = "abcde"
 * 
 * 输出：
 * e
 * 
 * 解释：
 * 'e' 是那个被添加的字母。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int[] flag = new int[26];
        foreach (var c in s)
        {
            flag[c - 'a']++;
        }

        foreach (var c in t)
        {
            flag[c - 'a']--;
        }

        for (int i = 0; i < 26; i++)
        {
            if (flag[i] < 0)
            {
                return (char)('a' + i);
            }
        }

        return 'a';
    }
}
// @lc code=end

