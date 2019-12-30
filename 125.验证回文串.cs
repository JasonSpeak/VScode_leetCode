/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 *
 * https://leetcode-cn.com/problems/valid-palindrome/description/
 *
 * algorithms
 * Easy (41.37%)
 * Likes:    134
 * Dislikes: 0
 * Total Accepted:    68.8K
 * Total Submissions: 164.6K
 * Testcase Example:  '"A man, a plan, a canal: Panama"'
 *
 * 给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
 * 
 * 说明：本题中，我们将空字符串定义为有效的回文串。
 * 
 * 示例 1:
 * 
 * 输入: "A man, a plan, a canal: Panama"
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: "race a car"
 * 输出: false
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left <= right)
        {
            if (!IsInRange(s[left]))
            {
                left++;
                continue;
            }

            if (!IsInRange(s[right]))
            {
                right--;
                continue;
            }

            if (s[left] != s[right] && !IsSameChar(s[left], s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
    private bool IsInRange(char c)
    {
        if ((c >= 48 && c <= 57) || (c >= 65 && c <= 90) || (c >= 97 && c <= 122))
        {
            return true;
        }

        return false;
    }

    private bool IsSameChar(char a, char b)
    {
        if ((a >= 48 && a <= 57) || (b >= 48 && b <= 57))
        {
            return false;
        }
        return a > b ? a == (b + 32) : a == (b - 32);
    }
}
// @lc code=end

