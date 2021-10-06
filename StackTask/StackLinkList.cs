using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    class StackLinkList<T> : IStack<T>
    {
        private readonly LinkedList<T> _stackLinkList;
        public StackLinkList()
        {
            _stackLinkList = new LinkedList<T>();
        }

        public void Push(T a)
        {
            _stackLinkList.AddLast(a);
        }

        public T Pop()
        {
            T x = _stackLinkList.Last.Value;
            _stackLinkList.RemoveLast();
            return x;
        }

        public void Print()
        {
                foreach (var item in _stackLinkList)
                {
                    Console.WriteLine(item.ToString());
                }        
        }

        public void Peak()
        {
            if (_stackLinkList.Count >= 1)
                Console.WriteLine(_stackLinkList.Last.Value.ToString());
        }

        public void Clear()
        {
            _stackLinkList.Clear();
        }
        
        public void PrintByDelegate(Action<T> stackDelegate)
        {
            foreach (var stackElement in _stackLinkList)
            {
                stackDelegate(stackElement);
            }
        }

    }
}
