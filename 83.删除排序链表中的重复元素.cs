/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var currentPoint = head;
        var tempPoint = head;
        while (currentPoint.next != null)
        {
            while (tempPoint != null)
            {
                if (currentPoint.val != tempPoint.val)
                {
                    currentPoint.next = tempPoint;
                    currentPoint = tempPoint;
                }

                tempPoint = tempPoint.next;
            }

            currentPoint.next = null;
        }

        return head;
    }
}
// @lc code=end

