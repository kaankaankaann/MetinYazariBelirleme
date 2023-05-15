using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Yazari_Belirleme
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Peek();
        bool IsEmpty();
    }
}
