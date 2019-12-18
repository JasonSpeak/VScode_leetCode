/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        if (string.IsNullOrWhiteSpace(s))
                return 0;
            int count = s.Length;
            int lastWordLength = 0;
            bool isBeginCount = false;
            for (int i = count-1; i >=0; i--)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    if (!isBeginCount)
                    {
                        isBeginCount = true;
                    }
                    lastWordLength++;
                }
                else
                {
                    if (isBeginCount)
                    {
                        break;
                    }
                }
            }

            return lastWordLength;
    }
}
// @lc code=end

