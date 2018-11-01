using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    class Queue
    {
        private LinkedList<object> _queue;

        public Queue()
        {
            _queue = new LinkedList<object>();
        }

        public void Enqueue(object obj)
        {
            if (_queue != null)
            {
                _queue.AddLast(obj);
            }
            else
            {
                throw new InvalidOperationException("Cannot add to a queue until it exists!");
            }            
        }

        public object Dequeue()
        {
            object first = null;
            if (_queue != null && _queue.Count > 0)
            {
                first = Peek();
                _queue.RemoveFirst();
            }
            else if (_queue != null)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            else
            {
                throw new InvalidOperationException("Cannot access a nonexistent queue!");
            }
            return first;
        }

        public object Peek()
        {
            object first = null;
            if (_queue != null && _queue.Count > 0)
            {
                first = _queue.First();
            }
            else if (_queue != null)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            else
            {
                throw new InvalidOperationException("Cannot access a nonexistent queue!");
            }
            return first;
        }

        public void Clear()
        {
            if (_queue != null)
            {
                _queue.Clear();
            }
            else
            {
                throw new InvalidOperationException("Cannot access a queue until it exists!");
            }
        }
    }
}
