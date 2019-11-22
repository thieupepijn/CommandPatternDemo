using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{

    public class StackException : Exception
    {
        public StackException() : base() { }
        public StackException(string message) : base(message) { }

    };

    public class Stack<T>
    {

        private List<T> _innerList;

        public Stack()
        {
            _innerList = new List<T>();
        }


        public void Push(T item)
        {
            _innerList.Add(item);
        }

        public T Pop()
        {
            if (_innerList.Count > 0)
            {
                T item = _innerList[_innerList.Count - 1];
                _innerList.Remove(item);
                return item;
            }
            else
            {
                return default(T);
            }
        }

    }
}
