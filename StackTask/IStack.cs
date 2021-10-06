using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    public interface IStack<T>
    {
        void Push(T a);
        T Pop();
        void Print();
        void Peak();
        void Clear();
        void PrintByDelegate(Action<T> stackDelegate);
    }
}
