using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generyk {
    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return items[items.Count - 1];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }


    public class Queue<T>
    {
        private LinkedList<T> items;

        public Queue()
        {
            items = new LinkedList<T>();
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            T item = items.First.Value;
            items.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            return items.First.Value;
        }
    }
}
