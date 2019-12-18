/*
 * @lc app=leetcode.cn id=69 lang=csharp
 *
 * [69] x 的平方根
 */

// @lc code=start
public class Solution {
    public int MySqrt(int x) {
        if(x==0)
        {
            return 0;
        }
        
        long left = 1;
        long right = x / 2;
        while (left < right)
         {
            long mid = left + (right - left + 1) / 2;
            long square = mid * mid;
            if (square > x) {
                right = mid - 1;
            } else {
                left = mid;
            }
        }
        return (int) left;
    }
}
// @lc code=end

