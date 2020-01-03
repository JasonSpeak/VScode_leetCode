/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 *
 * https://leetcode-cn.com/problems/min-stack/description/
 *
 * algorithms
 * Easy (50.40%)
 * Likes:    347
 * Dislikes: 0
 * Total Accepted:    62.4K
 * Total Submissions: 122.9K
 * Testcase Example:  '["MinStack","push","push","push","getMin","pop","top","getMin"]\n[[],[-2],[0],[-3],[],[],[],[]]'
 *
 * 设计一个支持 push，pop，top 操作，并能在常数时间内检索到最小元素的栈。
 * 
 * 
 * push(x) -- 将元素 x 推入栈中。
 * pop() -- 删除栈顶的元素。
 * top() -- 获取栈顶元素。
 * getMin() -- 检索栈中的最小元素。
 * 
 * 
 * 示例:
 * 
 * MinStack minStack = new MinStack();
 * minStack.push(-2);
 * minStack.push(0);
 * minStack.push(-3);
 * minStack.getMin();   --> 返回 -3.
 * minStack.pop();
 * minStack.top();      --> 返回 0.
 * minStack.getMin();   --> 返回 -2.
 * 
 * 
 */

// @lc code=start
public class MinStack {

    /** initialize your data structure here. */
    private Stack<int> _data;
        private Stack<int> _helper;
    public MinStack() {
         _data = new Stack<int>();
            _helper = new Stack<int>();
    }
    
    public void Push(int x) {
        _data.Push(x);
            if (_helper.Count == 0 || x <= _helper.Peek())
            {
                _helper.Push(x);
            }
            else
            {
                _helper.Push(_helper.Peek());
            }
    }
    
    public void Pop() {
         _data.Pop();
            _helper.Pop();
    }
    
    public int Top() {
        return _data.Peek();
    }
    
    public int GetMin() {
        return _helper.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

