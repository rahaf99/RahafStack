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

        public void push(T a)
        {
            _stackLinkList.AddLast(a);
        }

        public T pop()
        {
            T x = _stackLinkList.Last.Value;
            _stackLinkList.RemoveLast();
            return x;
        }

        public void print()
        {
                foreach (var item in _stackLinkList)
                {
                    Console.WriteLine(item.ToString());
                }        
        }

        public void peak()
        {
            if (_stackLinkList.Count >= 1)
                Console.WriteLine(_stackLinkList.Last.Value.ToString());
        }

        public void clear()
        {
            _stackLinkList.Clear();
        }
        
        public void printByDelegate(Action<T> del)
        {
            foreach (var item in _stackLinkList)
            {
                del(item);
            }
        }
    }
}
