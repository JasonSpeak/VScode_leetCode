/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 *
 * https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/description/
 *
 * algorithms
 * Easy (51.22%)
 * Likes:    651
 * Dislikes: 0
 * Total Accepted:    104.8K
 * Total Submissions: 203K
 * Testcase Example:  '[7,1,5,3,6,4]'
 *
 * 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
 * 
 * 如果你最多只允许完成一笔交易（即买入和卖出一支股票），设计一个算法来计算你所能获取的最大利润。
 * 
 * 注意你不能在买入股票前卖出股票。
 * 
 * 示例 1:
 * 
 * 输入: [7,1,5,3,6,4]
 * 输出: 5
 * 解释: 在第 2 天（股票价格 = 1）的时候买入，在第 5 天（股票价格 = 6）的时候卖出，最大利润 = 6-1 = 5 。
 * ⁠    注意利润不能是 7-1 = 6, 因为卖出价格需要大于买入价格。
 * 
 * 
 * 示例 2:
 * 
 * 输入: [7,6,4,3,1]
 * 输出: 0
 * 解释: 在这种情况下, 没有交易完成, 所以最大利润为 0。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // int maxProfit = 0;
        // int tempMax = 0;
        // int currentDay = 0;
        // while (currentDay < prices.Length)
        // {
        //     for (int i = currentDay; i < prices.Length; i++)
        //     {
        //         int currentMax = prices[i] - prices[currentDay];
        //         tempMax = tempMax > currentMax ? tempMax : currentMax;
        //     }

        //     maxProfit = maxProfit > tempMax ? maxProfit : tempMax;
        //     tempMax = 0;
        //     currentDay++;
        // }
        // return maxProfit;
        // if (prices.Length < 2)
        // {
        //     return 0;
        // }

        // int maxProfit = 0;
        // int currentMin = prices[0];

        // for (int i = 1; i < prices.Length; i++)
        // {
        //     maxProfit = maxProfit > prices[i] - currentMin ? maxProfit : prices[i] - currentMin;
        //     currentMin = currentMin < prices[i] ? currentMin : prices[i];
        // }

        // return maxProfit;
        int n = prices.Length;
        if(n==0)
        {
            return 0;
        }
        int[,] dp = new int[n, 2];
        dp[0, 0] = 0;
        dp[0, 1] = -prices[0];
        for (int i = 1; i < n; i++)
        {
            dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
            dp[i, 1] = Math.Max(dp[i - 1, 1], -prices[i]);
        }

        return dp[n - 1, 0];
    }
}
// @lc code=end

