/*
 * @lc app=leetcode.cn id=234 lang=csharp
 *
 * [234] 回文链表
 *
 * https://leetcode-cn.com/problems/palindrome-linked-list/description/
 *
 * algorithms
 * Easy (39.01%)
 * Likes:    370
 * Dislikes: 0
 * Total Accepted:    55.8K
 * Total Submissions: 140.5K
 * Testcase Example:  '[1,2]'
 *
 * 请判断一个链表是否为回文链表。
 * 
 * 示例 1:
 * 
 * 输入: 1->2
 * 输出: false
 * 
 * 示例 2:
 * 
 * 输入: 1->2->2->1
 * 输出: true
 * 
 * 
 * 进阶：
 * 你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
 * 
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return true;
        }

        var fast = head;
        var slow = head;
        ListNode mid = null;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            var tmp = mid;
            mid = slow;
            slow = slow.next;
            mid.next = tmp;
        }

        ListNode left = null;
        ListNode right = null;

        if (fast == null)
        {
            right = slow;
            left = mid;
        }
        else
        {
            right = slow.next;
            left = mid;
        }

        while (right != null)
        {
            if (right.val != left.val)
            {
                return false;
            }

            right = right.next;
            left = left.next;
        }

        return true;
    }
}
// @lc code=end

