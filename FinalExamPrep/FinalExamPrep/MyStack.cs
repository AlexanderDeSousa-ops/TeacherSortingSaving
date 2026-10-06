using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class MyStack<T>
    {
        private T[] array;
        private int top;
        private int capacity;

        public MyStack(int size)
        {
            capacity = size;
            array = new T[capacity];
            top = -1;
        }
        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("the stack is full");
                return;
            }
            top++;
            array[top] = item;

        }
        public T Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
            T value = array[top];
            top--;
            return value;
        }
        public T Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
            return array[top];
        }
        public int Count()
        {
            return top + 1;
        }
        public void Clear()
        {
            top = -1;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i <= top; i++)
            {
                if (array[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public T[] ToArray()
        {
            T[] values = new T[top + 1];
            int index = 0;
            for (int i = top; i >= 0; i--)
            {
                values[index] = array[i];
            }
            return values;
        }
        public bool isEmpty()
        {
            return top == -1;
        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("stack elements are : ");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
