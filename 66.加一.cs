/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        int count = digits.Length;

            if (digits[count - 1] != 9)
            {
                digits[count - 1]++;
                return digits;
            }

            for (int i = count-1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    break;
                }

                if (i == 0)
                {
                    digits = new int[count+1];
                    foreach (var digit in digits)
                    {
                        digits[digit] = 0;
                    }
                    digits[0] = 1;
                }
            }

            return digits;
    }
}
// @lc code=end

