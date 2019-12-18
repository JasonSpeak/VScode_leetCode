/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 实现 strStr()
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
            int strCount = haystack.Length;
            int subCount = needle.Length;
            if (subCount == 0)
            {
                return 0;
            }

            if (strCount == 0)
            {
                return -1;
            }
            int[,] FSM = new int[subCount,256];
            int X = 0;
            int match = 0;
            for (int i = 0; i < subCount; i++)
            {
                match = (int) needle[i];
                for (int j = 0; j < 256; j++)
                {
                    FSM[i,j] = FSM[X,j];
                }

                FSM[i,match] = i + 1;
                if (i > 0)
                {
                    X = FSM[X,match];
                }
            }

            int state = 0;
            for (int i = 0; i < strCount; i++)
            {
                state = FSM[state,haystack[i]];
                if (state == subCount)
                {
                    return i - subCount + 1;
                }
            }

            return -1;
    }
}
// @lc code=end

