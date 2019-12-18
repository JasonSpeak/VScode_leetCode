/*
 * @lc app=leetcode.cn id=38 lang=csharp
 *
 * [38] 报数
 */

// @lc code=start
public class Solution {
    public string CountAndSay(int n) {
        if (n == 1)
            {
                return "1";
            }

            string nextString = CountAndSay(n - 1);

            int index = 0;
            int count = 1;
            string result = "";
            for (int i = 1; i < nextString.Length; i++)
            {
                if (nextString[i] == nextString[index])
                {
                    count++;
                }
                else
                {
                    result = result + count + nextString[index];
                    index = i;
                    count = 1;
                }

            }

            if (nextString[index] == nextString[nextString.Length - 1])
            {
                result = result + count + nextString[index];
            }


            return result ;
    }
}
// @lc code=end

