using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    class StackUsingLinkList<T>
    {
        private readonly LinkedList<T> _stackLinkList;
        public StackUsingLinkList()
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
            if (_stackLinkList.Count > 0)
            {
                foreach (var item in _stackLinkList)
                {
                    Console.WriteLine(item.ToString());
                }
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
    }
}
