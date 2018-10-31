using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Stack
    {
        private ArrayList _stack;

        public Stack()
        {
            _stack = new ArrayList();
        }
        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Cannot add null object to a stack!");
            }
            else
            {
                _stack.Add(obj);
            }
        }

        public object Pop()
        {
            object last = null;

            if (_stack != null && _stack.Count > 0)
            {
                last = _stack[_stack.Count-1];
                _stack.Remove(last);
            }
            else
            {
                throw new InvalidOperationException("Cannot access a stack until it exists!");
            }
            return last;
        }

        public void Clear()
        {
            if (_stack != null)
            {
                _stack.Clear();
            }
            else
            {
                throw new InvalidOperationException("Cannot access a stack until it exists!");
            }
        }
    }
}
