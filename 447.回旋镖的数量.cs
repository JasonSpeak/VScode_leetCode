/*
 * @lc app=leetcode.cn id=447 lang=csharp
 *
 * [447] 回旋镖的数量
 *
 * https://leetcode-cn.com/problems/number-of-boomerangs/description/
 *
 * algorithms
 * Easy (55.08%)
 * Likes:    73
 * Dislikes: 0
 * Total Accepted:    8.5K
 * Total Submissions: 15.1K
 * Testcase Example:  '[[0,0],[1,0],[2,0]]'
 *
 * 给定平面上 n 对不同的点，“回旋镖” 是由点表示的元组 (i, j, k) ，其中 i 和 j 之间的距离和 i 和 k
 * 之间的距离相等（需要考虑元组的顺序）。
 * 
 * 找到所有回旋镖的数量。你可以假设 n 最大为 500，所有点的坐标在闭区间 [-10000, 10000] 中。
 * 
 * 示例:
 * 
 * 
 * 输入:
 * [[0,0],[1,0],[2,0]]
 * 
 * 输出:
 * 2
 * 
 * 解释:
 * 两个回旋镖为 [[1,0],[0,0],[2,0]] 和 [[1,0],[2,0],[0,0]]
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int NumberOfBoomerangs(int[][] points)
    {
        var kv = new Hashtable();
            int result = 0;
            for (int i = 0; i < points.Length; i++)
            {
                kv.Clear();
                for (int j = 0; j < points.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    int distance = (points[i][0] - points[j][0]) * (points[i][0] - points[j][0]) +
                                   (points[i][1] - points[j][1]) * (points[i][1] - points[j][1]);

                    if (kv.ContainsKey(distance))
                    {
                        result += (int) kv[distance] * 2;
                        kv[distance] = (int) kv[distance] + 1;
                    }
                    else
                    {
                        kv.Add(distance,1);
                    }
                }
            }

            return result;
    }
}
// @lc code=end

