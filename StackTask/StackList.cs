using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    class StackList<T> : IStack<T>
    {
        private readonly List<T> _stackList;
        public StackList()
        {
            _stackList = new List<T>();
        }

        public void push(T a)
        {
            _stackList.Add(a);
        }

        public T pop()
        {
            T x = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return x;
        }

        public void print()
        {
            if (_stackList.Count > 0)
            {
                foreach (var item in _stackList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public void peak()
        {
            if (_stackList.Count >= 1)
                Console.WriteLine(_stackList[_stackList.Count - 1].ToString());
        }

        public void clear()
        {
            _stackList.Clear();
        }
    }
}
