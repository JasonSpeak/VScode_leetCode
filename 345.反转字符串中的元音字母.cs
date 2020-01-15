/*
 * @lc app=leetcode.cn id=345 lang=csharp
 *
 * [345] 反转字符串中的元音字母
 *
 * https://leetcode-cn.com/problems/reverse-vowels-of-a-string/description/
 *
 * algorithms
 * Easy (48.22%)
 * Likes:    66
 * Dislikes: 0
 * Total Accepted:    21.6K
 * Total Submissions: 44.5K
 * Testcase Example:  '"hello"'
 *
 * 编写一个函数，以字符串作为输入，反转该字符串中的元音字母。
 * 
 * 示例 1:
 * 
 * 输入: "hello"
 * 输出: "holle"
 * 
 * 
 * 示例 2:
 * 
 * 输入: "leetcode"
 * 输出: "leotcede"
 * 
 * 说明:
 * 元音字母不包含字母"y"。
 * 
 */

// @lc code=start
public class Solution
{

    public string ReverseVowels(string s)
    {
        List<char> vowels = new List<char>()
            {
                'a',
                'e',
                'i',
                'o',
                'u',
                'A',
                'E',
                'I',
                'O',
                'U'
            };
        StringBuilder res = new StringBuilder(s);
        int left = 0, right = s.Length - 1;
        while (left <= right)
        {
            if (!vowels.Contains(res[left]))
            {
                left++;
                continue;
            }

            if (!vowels.Contains(res[right]))
            {
                right--;
                continue;
            }

            var tmp = res[left];
            res[left] = res[right];
            res[right] = tmp;
            left++;
            right--;
        }

        return res.ToString();
    }
}
// @lc code=end

