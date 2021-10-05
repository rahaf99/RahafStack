using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    interface IStack<T>
    {
        void push(T a);
        T pop();
        void print();
        void peak();
        void clear();
    }
}
