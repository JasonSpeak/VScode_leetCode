/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 *
 * https://leetcode-cn.com/problems/implement-stack-using-queues/description/
 *
 * algorithms
 * Easy (61.01%)
 * Likes:    105
 * Dislikes: 0
 * Total Accepted:    26.1K
 * Total Submissions: 42.3K
 * Testcase Example:  '["MyStack","push","push","top","pop","empty"]\n[[],[1],[2],[],[],[]]'
 *
 * 使用队列实现栈的下列操作：
 * 
 * 
 * push(x) -- 元素 x 入栈
 * pop() -- 移除栈顶元素
 * top() -- 获取栈顶元素
 * empty() -- 返回栈是否为空
 * 
 * 
 * 注意:
 * 
 * 
 * 你只能使用队列的基本操作-- 也就是 push to back, peek/pop from front, size, 和 is empty
 * 这些操作是合法的。
 * 你所使用的语言也许不支持队列。 你可以使用 list 或者 deque（双端队列）来模拟一个队列 , 只要是标准的队列操作即可。
 * 你可以假设所有操作都是有效的（例如, 对一个空的栈不会调用 pop 或者 top 操作）。
 * 
 * 
 */

// @lc code=start
public class MyStack
{
    private Queue<int> q;

    /** Initialize your data structure here. */
    public MyStack()
    {
        q = new Queue<int>();

    }

    /** Push element x onto stack. */
    public void Push(int x)
    {
        var queue = new Queue<int>();
        queue.Enqueue(x);
        foreach (var elemet in q)
        {
            queue.Enqueue(elemet);
        }
        q = queue;
    }

    /** Removes the element on top of the stack and returns that element. */
    public int Pop()
    {
        return q.Dequeue();
    }

    /** Get the top element. */
    public int Top()
    {
        return q.First();
    }

    /** Returns whether the stack is empty. */
    public bool Empty()
    {
        return !q.Any();
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

