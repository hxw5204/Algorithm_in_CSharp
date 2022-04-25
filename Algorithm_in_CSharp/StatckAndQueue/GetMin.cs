using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.StatckAndQueue
{
    //实现一个特殊的栈， 在实现栈的基本功能的基础上，在实现返回栈中最小元素的操作
    // pop, push, getMin should be O(1)
    // can use existing stack structure

    
    internal class GetMin1
    {
        private Stack<int> stackData;
        private Stack<int> stackMin;

        public GetMin1()
        {
            this.stackData = new Stack<int>();
            this.stackMin = new Stack<int>();
        }

        public int getmin()
        {
            if(this.stackMin.Count == 0)
            {
                throw new Exception("Your stack is empty");
            }
            return this.stackMin.Peek();
        }

        public void push(int newNum)
        {
            if(this.stackMin.Count == 0)
            {
                this.stackMin.Push(newNum);
            }else if(newNum <= this.getmin())
            {
                this.stackMin.Push(newNum);
            }
            this.stackData.Push(newNum);
        }

        public int pop()
        {
            if(this.stackData.Count == 0)
            {
                throw new Exception("Your stack is empty");
            }
            int value = this.stackData.Pop();
            if(value == this.getmin())
            {
                this.stackMin.Pop();
            }
            return value;
        }
    }
}
