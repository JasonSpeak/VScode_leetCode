/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder result = new StringBuilder();
            int isPreAdd = 0;
            for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                int tempSum = isPreAdd;
                tempSum += i >= 0 ? a[i]-'0' : 0;
                tempSum += j >= 0 ? b[j]-'0' : 0;
                result.Append(tempSum % 2);
                isPreAdd = tempSum / 2;
            }

            if (isPreAdd==1)
            {
                result.Append(isPreAdd.ToString());
            }

            var answer = result.ToString().ToCharArray();
            Array.Reverse(answer);

            return new string(answer);
    }
}
// @lc code=end


