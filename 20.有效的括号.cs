/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
            if (s.Length == 0)
            {
                return true;
            }

            if (s.Length == 1)
            {
                return false;
            }
            while (true)
            {
                if (s.Length == 0)
                {
                    return true;
                }
                if (s.IndexOf("()") >= 0 || s.IndexOf("{}") >= 0 || s.IndexOf("[]") >= 0)
                {
                    s = s.Replace("()", "");
                    s = s.Replace("[]", "");
                    s = s.Replace("{}", "");
                }
                else
                {
                    return false;
                }
            }
    }
}
// @lc code=end

