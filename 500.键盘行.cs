/*
 * @lc app=leetcode.cn id=500 lang=csharp
 *
 * [500] 键盘行
 *
 * https://leetcode-cn.com/problems/keyboard-row/description/
 *
 * algorithms
 * Easy (68.24%)
 * Likes:    78
 * Dislikes: 0
 * Total Accepted:    14.3K
 * Total Submissions: 21K
 * Testcase Example:  '["Hello","Alaska","Dad","Peace"]'
 *
 * 给定一个单词列表，只返回可以使用在键盘同一行的字母打印出来的单词。键盘如下图所示。
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 示例：
 * 
 * 输入: ["Hello", "Alaska", "Dad", "Peace"]
 * 输出: ["Alaska", "Dad"]
 * 
 * 
 * 
 * 
 * 注意：
 * 
 * 
 * 你可以重复使用键盘上同一字符。
 * 你可以假设输入的字符串将只包含字母。
 * 
 */

// @lc code=start
public class Solution
{
    public string[] FindWords(string[] words)
    {
        Hashtable kv = new Hashtable();
        string firstLine = "qwertyuiop";
        string secondLine = "asdfghjkl";
        string thirdLine = "zxcvbnm";
        foreach (var item in firstLine)
        {
            kv.Add(item, 1);
        }
        foreach (var item in secondLine)
        {
            kv.Add(item, 2);
        }
        foreach (var item in thirdLine)
        {
            kv.Add(item, 3);
        }

        List<string> result = new List<string>();

        foreach (var word in words)
        {
            string tempWord = word.ToLower();
            int defaultLevel = (int)kv[tempWord[0]];
            for (int i = 0; i < tempWord.Length; i++)
            {
                if ((int)kv[tempWord[i]] != defaultLevel)
                {
                    break;
                }
                if (i == tempWord.Length - 1)
                {
                    result.Add(word);
                }
            }
        }

        return result.ToArray();
    }
}
// @lc code=end

