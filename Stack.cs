using System;
using System.Collections;

namespace Stack
{
    public class Stack
    {
        private readonly ArrayList _stack = new ArrayList();

        // Stores an object on the stack.
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null cannot be pushed on to the stack.");
            }

            _stack.Add(obj);
        }

        // Removes and returns the object from the top of the stack.
        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop a value from an empty stack.");
            }

            var pop = _stack[_stack.Count - 1];

            _stack.RemoveAt(_stack.Count - 1);

            return pop;
        }

        // Empties out the stack.
        public void Clear()
        {
            var cnt = _stack.Count - 1;
            while (_stack.Count != 0)
            {
                _stack.RemoveAt(cnt--);
            }
        }
    }
}