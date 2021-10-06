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

        public void Push(T a)
        {
            _stackList.Add(a);
        }

        public T Pop()
        {
            T x = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return x;
        }

        public void Print()
        {
            foreach (var item in _stackList)
                {
                    Console.WriteLine(item.ToString());
                }
        }

        public void Peak()
        {
            if (_stackList.Count >= 1)
                Console.WriteLine(_stackList[_stackList.Count - 1].ToString());
        }

        public void Clear()
        {
            _stackList.Clear();
        }

        void IStack<T>.PrintByDelegate(Action<T> stackDelegate)
        {
            foreach (var stackElement in _stackList)
            {
                stackDelegate(stackElement);
            }
        }
    }
}
