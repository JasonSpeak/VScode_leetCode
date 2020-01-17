/*
 * @lc app=leetcode.cn id=401 lang=csharp
 *
 * [401] 二进制手表
 *
 * https://leetcode-cn.com/problems/binary-watch/description/
 *
 * algorithms
 * Easy (49.91%)
 * Likes:    99
 * Dislikes: 0
 * Total Accepted:    9.4K
 * Total Submissions: 18.4K
 * Testcase Example:  '0'
 *
 * 二进制手表顶部有 4 个 LED 代表小时（0-11），底部的 6 个 LED 代表分钟（0-59）。
 * 
 * 每个 LED 代表一个 0 或 1，最低位在右侧。
 * 
 * 
 * 
 * 例如，上面的二进制手表读取 “3:25”。
 * 
 * 给定一个非负整数 n 代表当前 LED 亮着的数量，返回所有可能的时间。
 * 
 * 案例:
 * 
 * 
 * 输入: n = 1
 * 返回: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16",
 * "0:32"]
 * 
 * 
 * 
 * 注意事项:
 * 
 * 
 * 输出的顺序没有要求。
 * 小时不会以零开头，比如 “01:00” 是不允许的，应为 “1:00”。
 * 分钟必须由两位数组成，可能会以零开头，比如 “10:2” 是无效的，应为 “10:02”。
 * 
 * 
 */

// @lc code=start
public class Solution {
    public IList<string> ReadBinaryWatch(int num)
        {
            var dictA = new Dictionary<int, List<int>>();
            var res = new List<string>();
            for (var i = 0; i < 12; i++)
            {
                var t = BitCount(i);
                if (dictA.ContainsKey(t))
                {
                    dictA[t].Add(i);
                }
                else
                {
                    dictA[t] = new List<int> { i };
                }
            }

            var dictB = new Dictionary<int, List<int>>();
            for (var i = 0; i < 60; i++)
            {
                var t = BitCount(i);
                if (dictB.ContainsKey(t))
                {
                    dictB[t].Add(i);
                }
                else
                {
                    dictB[t] = new List<int> { i };
                }
            }
            for (var i = 0; i <= 4 && dictA.ContainsKey(i); i++)
            {
                var j = num - i;
                if (j >= 0 && dictB.ContainsKey(j))
                {
                    foreach (var a in dictA[i])
                    {
                        foreach (var b in dictB[j])
                        {
                            if (b < 10)
                            {
                                res.Add($"{a}:0{b}");
                            }
                            else
                            {
                                res.Add($"{a}:{b}");
                            }
                        }
                    }

                }
            }
            return res;
        }


        static int BitCount(int n)
        {
            var count = 0;
            while (n > 0)
            {
                n &= (n - 1);
                count++;
            }
            return count;
        }
}
// @lc code=end

