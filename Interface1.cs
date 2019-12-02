using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    interface IActions<T>
    {
        void Push(T element);
        T Pop();
        T Peek();
        void show(T element);
    }
}
