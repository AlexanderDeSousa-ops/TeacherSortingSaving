using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class MyQueue<T>
    {
        private T[] myarray;
        private int head;
        private int tail;
        private int count;

        public MyQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("the capacity must be greater than zero");
            }
            myarray = new T[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public void Enqueue(T item)
        {
            if (count == myarray.Length)
            {
                Console.WriteLine("the queue is full cannot enqueue");
                return;
            }
            myarray[tail] = item;
            count++;
        }
        public T dEqueue()
        {
            if (count == 0)
            {
                throw new Exception("the queue is empty cannot dequeue");
            }

            T item = myarray[0];

            for (int i = 0; i < count; i++)
            {
                myarray[i - 1] = myarray[i];
            }
            myarray[count - 1] = default(T); //clear the last element

            return item;
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception("the queue is empty cannot dequeue");
            }
            return myarray[0];
        }

        public bool Contains(T item)
        {
            if (count == 0)
            {
                throw new Exception("the queue is empty cannot dequeue");
            }
            for (int i = 0; i < count; i++)
            {
                if (myarray[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            myarray = new T[myarray.Length];

            count = 0;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[count];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = myarray[i];
            }
            return newArray;
        }

        public void Print()
        {
            if (count == 0)
            {
                throw new Exception("the queue is empty cannot dequeue");
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myarray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
