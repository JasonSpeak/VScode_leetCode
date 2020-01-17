/*
 * @lc app=leetcode.cn id=409 lang=csharp
 *
 * [409] 最长回文串
 *
 * https://leetcode-cn.com/problems/longest-palindrome/description/
 *
 * algorithms
 * Easy (50.54%)
 * Likes:    91
 * Dislikes: 0
 * Total Accepted:    14K
 * Total Submissions: 27.3K
 * Testcase Example:  '"abccccdd"'
 *
 * 给定一个包含大写字母和小写字母的字符串，找到通过这些字母构造成的最长的回文串。
 * 
 * 在构造过程中，请注意区分大小写。比如 "Aa" 不能当做一个回文字符串。
 * 
 * 注意:
 * 假设字符串的长度不会超过 1010。
 * 
 * 示例 1: 
 * 
 * 
 * 输入:
 * "abccccdd"
 * 
 * 输出:
 * 7
 * 
 * 解释:
 * 我们可以构造的最长的回文串是"dccaccd", 它的长度是 7。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int LongestPalindrome(string s)
    {
        var kv = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {
                if (kv.ContainsKey(s[i]))
                {
                    kv[s[i]] = (int) kv[s[i]] + 1;
                }
                else
                {
                    kv.Add(s[i],1);
                }
            }

            int maxLength = 0;
            foreach (DictionaryEntry entry in kv)
            {
                if ((int) entry.Value >= 2)
                {
                    maxLength += (int) entry.Value / 2 * 2;
                }
            }

            return maxLength==s.Length ? maxLength : maxLength + 1;
    }
}
// @lc code=end

