using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Yazari_Belirleme
{
    public class Stack<T> : IStack<T>
    {
        private class Node
        {
            public T data { get; set; }
            public Node next { get; set; }
            public Node(T d, Node n)
            {
                data = d;
                next = n;
            }
        }

        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        private Node top = null;

        public bool IsEmpty()
        {
            return top == null;
        }

        public T Peek()
        {
            return top.data;
        }

        public T Pop()
        {
            Node temp = top;
            top = top.next;
            count--;
            return temp.data;
        }

        public void Push(T item)
        {
            Node node = new Node(item, top);
            top = node;
            count++;
        }
        
        public T[] ToArray()
        {
            Node node = top;
            T[] array = new T[count];
            for (int i = count-1; -1 < i; i--)
            {
                array[i] = node.data;
                node = node.next;
            }
            return array;
        }
    }
}
