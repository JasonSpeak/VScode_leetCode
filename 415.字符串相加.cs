/*
 * @lc app=leetcode.cn id=415 lang=csharp
 *
 * [415] 字符串相加
 *
 * https://leetcode-cn.com/problems/add-strings/description/
 *
 * algorithms
 * Easy (48.07%)
 * Likes:    125
 * Dislikes: 0
 * Total Accepted:    21K
 * Total Submissions: 43K
 * Testcase Example:  '"0"\n"0"'
 *
 * 给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。
 * 
 * 注意：
 * 
 * 
 * num1 和num2 的长度都小于 5100.
 * num1 和num2 都只包含数字 0-9.
 * num1 和num2 都不包含任何前导零。
 * 你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        int point1 = num1.Length - 1;
        int point2 = num2.Length - 1;
        var result = string.Empty;
        int addNum = 0;
        while (point1 >= 0 && point2 >= 0)
        {
            var cNum1 = num1[point1] - '0';
            var cNum2 = num2[point2] - '0';
            var tmpRes = cNum1 + cNum2 + addNum;
            if (tmpRes > 9)
            {
                addNum = 1;
                tmpRes = tmpRes % 10;
            }
            else
            {
                addNum = 0;
            }

            result += tmpRes;
            point1--;
            point2--;
        }

        if (point1 < 0 && point2 >= 0)
        {
            for (int i = point2; i >= 0; i--)
            {
                var tmpRes = num2[i] - '0' + addNum;
                if (tmpRes > 9)
                {
                    addNum = 1;
                    tmpRes = tmpRes % 10;
                }
                else
                {
                    addNum = 0;
                }
                result += tmpRes;
            }
        }

        if (point1 >= 0 && point2 < 0)
        {
            for (int i = point1; i >= 0; i--)
            {
                var tmpRes = num1[i] - '0' + addNum;
                if (tmpRes > 9)
                {
                    addNum = 1;
                    tmpRes = tmpRes % 10;
                }
                else
                {
                    addNum = 0;
                }
                result += tmpRes;
            }
        }

        if (addNum == 1)
            {
                result += 1;
            }


        return new string(result.Reverse().ToArray());
    }
}
// @lc code=end

