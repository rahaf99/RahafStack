using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    public interface IStack<T>
    {
        void push(T a);
        T pop();
        void print();
        void peak();
        void clear();
    }
}
